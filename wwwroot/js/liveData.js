//let dataRows = [];
//let rowId = new Set();
//let recordId = 1;
//let gridPeriod = 1 * 60 * 1000;
//let chartPeriod = 5 * 60 * 1000;
//let chart;

const PERIOD = {
    GRID: 1 * 60 * 1000,
    CHART: 5 * 60 * 1000
};
const state = {
    dataRows: [],
    rowId: new Set(),
    recordId: 1,
    chart: null
};

//function fetchData() {
//    fetch(getBtcEurDataUrl, {
//        method: 'GET'
//    })
//    .then(response => {
//        if (!response.ok) {
//            throw new Error("Chyba: " + response.statusText);
//        }
//        return response.json();
//    })
//        .then(data => {
//            addRecord(data);
//            updateGrid();
//        })
//        .catch(error => {
//            console.error("Chyba při získávání dat: ", error);
//        });
//}

async function fetchData() {
    try {
        const response = await fetch(getBtcEurDataUrl);

        if (!response.ok) {
            throw new Error(`Chyba: ${response.statusText}`);
        }

        const data = await response.json();

        addRecord(data);
        updateGrid();
    } catch (error) {
        console.error("Chyba při získávání dat: ", error);
    }
}

function formatDate(date) {
    const year = date.getFullYear();
    const month = (date.getMonth() + 1).toString().padStart(2, '0');
    const day = date.getDate().toString().padStart(2, '0');
    const hours = date.getHours().toString().padStart(2, '0');
    const minutes = date.getMinutes().toString().padStart(2, '0');
    const seconds = date.getSeconds().toString().padStart(2, '0');
    return `${year}-${month}-${day} ${hours}:${minutes}:${seconds}`;
}

function addRecord(data) {
    const currentDate = new Date();
    const record = {
        id: state.recordId++,
        timestamp: currentDate,
        dateFormatted: formatDate(currentDate),
        btcEurPrice: data.Data["BTC-EUR"].PRICE,
        btcCzePrice: data.EURCZE
    };
    state.dataRows.unshift(record);
}

function updateGrid() {
    const tbody = document.querySelector("#liveDataTable tbody");
    const now = new Date();

    const gridData = state.dataRows.filter(record => now - record.timestamp <= PERIOD.GRID);
    state.dataRows = state.dataRows.filter(record => now - record.timestamp <= PERIOD.CHART);

    tbody.innerHTML = "";

    const currentId = new Set();

    gridData.forEach(record => {
        currentId.add(record.id);

        const tr = document.createElement("tr");

        const tdDate = document.createElement("td");
        tdDate.textContent = record.dateFormatted;

        const tdBtcEur = document.createElement("td");
        tdBtcEur.textContent = record.btcEurPrice;

        const tdBtcCze = document.createElement("td");
        tdBtcCze.textContent = record.btcCzePrice;

        const tdButton = document.createElement("td");
        const button = document.createElement("button");
        button.textContent = "Uložit Data";
        button.addEventListener("click", function () {
            saveData(record.dateFormatted, record.btcEurPrice, record.btcCzePrice);
        });
        tdButton.appendChild(button);

        tr.appendChild(tdDate);
        tr.appendChild(tdBtcEur);
        tr.appendChild(tdBtcCze);
        tr.appendChild(tdButton);

        if (!state.rowId.has(record.id)) {
            tr.classList.add("blink");
            setTimeout(() => {
                tr.classList.remove("blink");
            }, 1000);
        }

        tbody.appendChild(tr);
    });

    state.rowId = currentId;

    updateChart();
}

function updateChart() {
    const now = new Date();
    let filteredData = state.dataRows.filter(record => now - record.timestamp <= PERIOD.CHART);
    let sortedData = filteredData.slice().reverse();

    const labels = sortedData.map(record => record.dateFormatted);
    const btcCzePrices = sortedData.map(record => record.btcCzePrice);

    if (!state.chart) {
        const ctx = document.getElementById('chartCanvas').getContext('2d');
        state.chart = new Chart(ctx, {
            type: 'line',
            data: {
                labels: labels,
                datasets: [
                    {
                        label: 'BTC / CZE',
                        data: btcCzePrices,
                        borderColor: 'red',
                        fill: false
                    }
                ]
            },
            options: {
                scales: {
                    x: {
                        title: {
                            display: true,
                            text: 'Čas'
                        }
                    },
                    y: {
                        title: {
                            display: true,
                            text: 'Cena'
                        }
                    }
                }
            }
        });
    } else {
        state.chart.data.labels = labels;
        state.chart.data.datasets[0].data = btcCzePrices;
        state.chart.update();
    }
}

function saveData(date, btcEur, btcCze) {
    const dataToSave = {
        date: date.replace(" ", "T"),
        btcEur: btcEur,
        btcCze: btcCze
    };

    fetch(saveDataUrl, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(dataToSave)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error("Chyba při ukládání dat");
            }
            return response.json();
        })
        .then(result => {
            console.log("Data byla úspěšně uložena", result);
            alert("Data byla úspěšně uložena!");
        })
        .catch(error => {
            console.error("Chyba při ukládání dat:", error);
            alert("Chyba při ukládání dat, zkuste to prosím znovu.");
        });
}

fetchData();
setInterval(fetchData, 10000);