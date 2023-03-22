using CsvHelper;
using IndianStateCensusAnalyserEx;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace IndianStateCensusAnalyserEX
{
    public class StateCensusAnalyzer
    {
        public int ReadStateCensusData(String filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new IndianStateExceptions(IndianStateExceptions.IndianStateExceptionType.INCORRECT_PATH, "Incorrect Path");
            }
            if (!filePath.EndsWith(".csv"))
            {
                throw new IndianStateExceptions(IndianStateExceptions.IndianStateExceptionType.INCORRECT_TYPE, "The Given File is not CSV");
            }
            var csvFile = File.ReadAllLines(filePath);
            var header = csvFile[0];
            if (header.Contains("/"))
            {
                throw new IndianStateExceptions(IndianStateExceptions.IndianStateExceptionType.INCORRECT_DELIMITER, "Incorrect Delimiter");
            }
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusAnalyserModel>().ToList();
                    foreach (var record in records)
                    {
                        //Console.WriteLine($"{record.State} {record.Population} {record.AreaInSqKm} {record.DensityPerSqKm}");
                        Console.WriteLine(record);
                    }

                    return records.Count() - 1;
                }
            }
        }
        public bool ReadStateCensusData(string filePath, string actualHeader)
        {
            var csvfile = File.ReadAllLines(filePath);
            string header = csvfile[0];

            if (!header.Equals(actualHeader ))
                return true;
            else
                throw new IndianStateExceptions(IndianStateExceptions.IndianStateExceptionType.INCORRECT_HEADER, "Incorrect Header");

        }
    }
}
