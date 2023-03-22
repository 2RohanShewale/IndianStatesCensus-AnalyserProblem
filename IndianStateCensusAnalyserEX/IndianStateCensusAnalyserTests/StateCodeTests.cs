using IndianStateCensusAnalyserEX;

namespace IndianStateCensusAnalyserTests
{
    public class StateCodeTests
    {
        public static string stateCodePath = @"C:\Users\shewa\RFP-256\IndianStatesCensus-AnalyserProblem\IndianStateCensusAnalyserEX\IndianStateCensusAnalyserEX\Files\StateCode.csv";

        CsvStateCode csvStateCode = new CsvStateCode();
        StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
        [Test]
        public void GivenStateCodeDataShoubldMatchNumberOfRecords()
        {
            
            Assert.AreEqual(csvStateCode.ReadStateCode(stateCodePath),stateCodeAnalyzer.ReadStateCode(stateCodePath));
        }

    }
}
