using IndianStateCensusAnalyserEx;
using IndianStateCensusAnalyserEX;

namespace IndianStateCensusAnalyserTests
{
    public class Tests
    {
        public static string stateCensusDataPath = @"C:\Users\shewa\RFP-256\IndianStatesCensus-AnalyserProblem\IndianStateCensusAnalyserEX\IndianStateCensusAnalyserEX\Files\StateCensusData.csv";

        CsvStateCensus csvStateCensus = new CsvStateCensus();
        StateCensusAnalyzer stateCensus = new StateCensusAnalyzer();

        [Test]
        public void GivenStateCensusDataShouldMatchNumberOfReturnMatches()
        {
            Assert.AreEqual(stateCensus.ReadStateCensusData(stateCensusDataPath),csvStateCensus.ReadStateCensusData(stateCensusDataPath));
        }
       
    }
}