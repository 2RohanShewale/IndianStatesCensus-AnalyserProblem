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
    }
}
