using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserEX
{
    public class IndianStateExceptions:Exception
    {
        public enum IndianStateExceptionType
        {
            INCORRECT_PATH,
            INCORRECT_TYPE,
            INCORRECT_DELIMITER,
            INCORRECT_HEADER
        }
        public IndianStateExceptionType type;
        public IndianStateExceptions(IndianStateExceptionType type, string message):base(message)
        {
            this.type = type;
        }
    }
}
