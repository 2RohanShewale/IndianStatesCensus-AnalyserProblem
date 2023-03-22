using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserEX
{
    public class StateCodeAnalyzer
    {
        public int ReadStateCode(string filePath)
        {
            using (var streamReader = new StreamReader(filePath))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var records = csvReader.GetRecords<StateCodeModel>().ToList();
                    foreach (var record in records)
                    {
                        //Console.WriteLine($"{record.SrNo} {record.StateName} {record.TIN} {record.StateCode}");
                    }
                    return records.Count() - 1;
                }
            }
        }
    }
}
