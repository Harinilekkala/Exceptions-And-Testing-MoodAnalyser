using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser
{
    public class MoodAnalyser
    {
        public string mood;
        public MoodAnalyser()
        {

        }

        public MoodAnalyser(string mood)
        {
            this.mood = mood;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.mood.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood Shold not be Empty");
                }
                else if (this.mood.Contains("sad"))
                {
                    Console.WriteLine("Input Contains Sad");
                    return "Sad";
                }
                else
                {
                    Console.WriteLine("Input Contains Happy");
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood Should not be null");
            }
        }







    }
}
