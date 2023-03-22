using IndianStateCensusAnalyserEX;

namespace IndianStateCensusAnalyserTests
{
    public class StateCodeTests
    {
        public static string stateCodePath = @"C:\Users\shewa\RFP-256\IndianStatesCensus-AnalyserProblem\IndianStateCensusAnalyserEX\IndianStateCensusAnalyserEX\Files\StateCode.csv";
        public static string incorrectPath = @"C:\Users\shewa\RFP-256\IndianStatesCensus-AnalyserProblem\IndianStateCensusAnalyserEX\IndianStateCensusAnalyserEX\Files\StateCode.csv";

        CsvStateCode csvStateCode = new CsvStateCode();
        StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
        [Test]
        public void GivenStateCodeDataShoubldMatchNumberOfRecords()
        {
            
            Assert.AreEqual(csvStateCode.ReadStateCode(stateCodePath),stateCodeAnalyzer.ReadStateCode(stateCodePath));
        }
        [Test]
        public void GivenIncorrectPathShouldThrowPathNotCorrectException()
        {
            try
            {
                stateCodeAnalyzer.ReadStateCode(incorrectPath);
            }
            catch (IndianStateExceptions ex)
            {
                Assert.AreEqual("File Does Not Exist", ex.Message);
            }
        }

    }
}
