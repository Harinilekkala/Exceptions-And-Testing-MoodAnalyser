using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        private readonly ExceptionType type;
        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}