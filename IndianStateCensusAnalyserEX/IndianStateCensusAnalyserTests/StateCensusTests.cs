using IndianStateCensusAnalyserEx;
using IndianStateCensusAnalyserEX;

namespace IndianStateCensusAnalyserTests
{
    public class Tests
    {
        public static string stateCensusDataPath = @"C:\Users\shewa\RFP-256\IndianStatesCensus-AnalyserProblem\IndianStateCensusAnalyserEX\IndianStateCensusAnalyserEX\Files\StateCensusData.csv";
        public static string incorrectPath = @"C:\Users\shewa\RFP-256\IndianStatesCensus-AnalyserProblem\IndianStateCensusAnalyserEX\IndianStateCensusAnalyserEX\Files\StateCen.csv";
        public static string incorrectType = @"C:\Users\shewa\RFP-256\IndianStatesCensus-AnalyserProblem\IndianStateCensusAnalyserEX\IndianStateCensusAnalyserEX\Files\StateCensusData.txt";

        CsvStateCensus csvStateCensus = new CsvStateCensus();
        StateCensusAnalyzer stateCensus = new StateCensusAnalyzer();

        [Test]
        public void GivenStateCensusDataShouldMatchNumberOfReturnMatches()
        {
            Assert.AreEqual(stateCensus.ReadStateCensusData(stateCensusDataPath),csvStateCensus.ReadStateCensusData(stateCensusDataPath));
        }
        [Test]
        public void GivenIncorrectPathShouldThrowPathNotCorrectException()
        {
            try
            {
                stateCensus.ReadStateCensusData(incorrectPath);
            }
            catch (IndianStateCensusExceptions ex)
            {
                Assert.AreEqual("Incorrect Path", ex.Message);
            }
        }
        [Test]
        public void GivenIncorrectFileType()
        {
            try
            {
                stateCensus.ReadStateCensusData(incorrectType);
            }
            catch (IndianStateCensusExceptions ex)
            {
                Assert.AreEqual("The Given File is not CSV",ex.Message);
            }
        }
    }
}