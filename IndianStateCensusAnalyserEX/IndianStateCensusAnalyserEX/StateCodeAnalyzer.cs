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
            if (!File.Exists(filePath))
            {
                throw new IndianStateExceptions(IndianStateExceptions.IndianStateExceptionType.INCORRECT_PATH,"File Does Not Exist");
            }
            if(!filePath.EndsWith(".csv"))
            {
                throw new IndianStateExceptions(IndianStateExceptions.IndianStateExceptionType.INCORRECT_TYPE, "The Provide File is not CSV");
            }
            var csvFile = File.ReadAllLines(filePath);
            var header = csvFile[0];
            if (header.Contains("/"))
            {
                throw new IndianStateExceptions(IndianStateExceptions.IndianStateExceptionType.INCORRECT_DELIMITER, "Incorrect Delimiter");
            }
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
        public bool ReadStateCode(string filePath, string actualHeader)
        {
            var csvfile = File.ReadAllLines(filePath);
            string header = csvfile[0];

            if (!header.Equals(actualHeader))
                return true;
            else
                throw new IndianStateExceptions(IndianStateExceptions.IndianStateExceptionType.INCORRECT_HEADER, "Incorrect Header");

        }
    }
}
