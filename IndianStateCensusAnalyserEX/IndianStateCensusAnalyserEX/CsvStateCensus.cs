using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserEx
{
    public class CsvStateCensus
    {
        public void ReadStateCensusData(String filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusAnalyserModel>().ToList();
                    foreach (var record in records)
                    {
                        Console.WriteLine($"{record.State} {record.Population} {record.AreaInSqKm} {record.DensityPerSqKm}");
                    }
                }
            }
        }
    }
}
