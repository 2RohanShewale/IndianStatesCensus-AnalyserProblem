using IndianStateCensusAnalyserEX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserEx
{
    internal class Program
    {
        public static string stateCensusDataPath= @"C:\Users\shewa\RFP-256\IndianStateCensusAnalyserEx\IndianStateCensusAnalyserEx\Files\StateCensusData.csv";
        public static string stateCodePath = @"C:\Users\shewa\RFP-256\IndianStatesCensus-AnalyserProblem\IndianStateCensusAnalyserEX\IndianStateCensusAnalyserEX\Files\StateCode.csv";
        static void Main(string[] args)
        {

            //CsvStateCensus csv = new CsvStateCensus();
            //csv.ReadStateCensusData(filePath);
            CsvStateCode csvStateCode = new CsvStateCode();
            csvStateCode.ReadStateCode(stateCodePath);

            Console.ReadKey();
        }
    }
}
