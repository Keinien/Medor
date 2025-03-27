using Medor.Models.API.CNB_API;
using System.Globalization;

namespace Medor.Services;

public class CnbApiParser
{
    public DataFile ParseData(string text)
    {
        var lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        if (lines.Length < 3)
            throw new Exception("Text nemá požadovanou strukturu.");

        var firstLineParts = lines[0].Split('#');
        if (firstLineParts.Length < 2)
            throw new Exception("První řádek nemá správný formát.");

        DateTime date = DateTime.ParseExact(firstLineParts[0].Trim(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
        int recordNumber = int.Parse(firstLineParts[1].Trim());

        var header = lines[1].Split('|');

        var rates = lines
            .Skip(2)
            .Select(line =>
            {
                var values = line.Split('|');

                string rateString = values[4]
                    .Replace("eur", "", StringComparison.InvariantCultureIgnoreCase)
                    .Replace("?", "")
                    .Trim();

                return new CurrencyRate
                {
                    Country = values[0].Trim(),
                    Currency = values[1].Trim(),
                    Quantity = int.Parse(values[2].Trim()),
                    Code = values[3].Trim(),
                    Rate = decimal.Parse(rateString, new CultureInfo("cs-CZ"))
                };
            })
            .ToList();

        return new DataFile
        {
            Date = date,
            RecordNumber = recordNumber,
            Rates = rates
        };
    }
}