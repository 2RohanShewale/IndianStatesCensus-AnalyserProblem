using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserEX
{
    public class IndianStateCensusExceptions:Exception
    {
        public enum IndianStateException
        {
            INCORRECT_PATH,
            INCORRECT_TYPE,
            INCORRECT_DELIMITER
        }
        public IndianStateException type;
        public IndianStateCensusExceptions(IndianStateException type, string message):base(message)
        {
            this.type = type;
        }
    }
}
