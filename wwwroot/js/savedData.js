window.saveRecord = saveRecord;

function loadGridData() {
    fetch(getSavedDataUrl, {
        method: 'GET'
    })
        .then(response => {
            if (!response.ok) {
                throw new Error("Chyba: " + response.statusText);
            }
            return response.json();
        })
        .then(data => {
            console.log("Načtená data:", data);
            const wrapper = document.getElementById("wrapper");
            wrapper.innerHTML = "";
            new gridjs.Grid({
                columns: [
                    { name: "Id", hidden: true },
                    "Date",
                    "BTC / EUR",
                    "BTC / CZE",
                    {
                        name: "Poznámka",
                        formatter: (cell, row) => gridjs.html(
                            `<textarea data-id="${row.cells[0].data}">${cell || ""}</textarea>`
                        )
                    },
                    {
                        name: "Smazání",
                        formatter: (_, row) => gridjs.html(
                            `<input type="checkbox" data-id="${row.cells[0].data}" />`
                        )
                    },
                    {
                        name: "Akce",
                        formatter: (_, row) => gridjs.html(
                            `<button onclick="saveRecord(${row.cells[0].data})">Uložit</button>`
                        )
                    }
                ],
                data: data.map(item => [
                    item.id,
                    item.datum,
                    item.btceur,
                    item.btccze,
                    item.note || "",
                    item.checked,
                    ""
                ]),
                search: false,
                pagination: {
                    enabled: true,
                    limit: 10
                }
            }).render(document.getElementById("wrapper")).forceRender();
        })
        .catch(error => {
            console.error("Chyba při načítání dat: ", error);
        });
}

function saveRecord(id) {
    const textarea = document.querySelector(`textarea[data-id="${id}"]`);
    const note = textarea ? textarea.value : "";

    const updateData = {
        id: id,
        note: note
    };

    fetch(updateNoteUrl, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(updateData)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error("Chyba při aktualizaci poznámky");
            }
            return response.json();
        })
        .then(result => {
            console.log("Poznámka úspěšně aktualizována", result);
        })
        .catch(error => {
            console.error("Chyba při aktualizaci poznámky:", error);
        });
}

document.addEventListener("DOMContentLoaded", function () {
    document.querySelector("#deleteSelectedBtn").addEventListener("click", deleteSelectedRecords);
});

function deleteSelectedRecords() {
    const checkedCheckboxes = document.querySelectorAll('#wrapper input[type="checkbox"]:checked');
    const idsToDelete = Array.from(checkedCheckboxes).map(cb => cb.getAttribute('data-id'));

    if (idsToDelete.length === 0) {
        alert("Nejsou vybrány žádné záznamy k odstranění.");
        return;
    }

    if (!confirm(`Opravdu chceš smazat ${idsToDelete.length} záznam(ů)?`)) {
        return;
    }

    fetch(deleteRecordsUrl, {
        method: 'DELETE',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ ids: idsToDelete })
    })
        .then(response => {
            if (!response.ok) {
                throw new Error("Chyba při mazání záznamů");
            }
            return response.json();
        })
        .then(result => {
            console.log("Záznamy úspěšně smazány", result);
            loadGridData();
        })
        .catch(error => {
            console.error("Chyba při mazání záznamů:", error);
        });
}

document.addEventListener("DOMContentLoaded", function () {
    document.querySelectorAll('a[data-bs-toggle="tab"]').forEach(tab => {
        tab.addEventListener('shown.bs.tab', event => {
            if (event.target.id === 'savedDataTabLink') {
                loadGridData();
            }
        });
    });
});
