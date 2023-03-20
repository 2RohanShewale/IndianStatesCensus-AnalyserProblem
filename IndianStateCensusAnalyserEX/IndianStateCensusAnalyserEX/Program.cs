using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserEx
{
    internal class Program
    {
        public static string filePath= @"C:\Users\shewa\RFP-256\IndianStateCensusAnalyserEx\IndianStateCensusAnalyserEx\Files\StateCensusData.csv";
        static void Main(string[] args)
        {

            CsvStateCensus csv = new CsvStateCensus();
            csv.ReadStateCensusData(filePath);
            Console.ReadKey();
        }
    }
}
