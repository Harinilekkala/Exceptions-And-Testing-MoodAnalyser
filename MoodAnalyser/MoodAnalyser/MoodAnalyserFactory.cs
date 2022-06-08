using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;


namespace Mood_Analyser
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyze(string className, string constructor)
        {
            string pattern = @"^" + constructor + "$";
            Match result = Regex.Match(pattern, className);
            if (result.Success)
            {
                try
                {
                    Assembly findAssembly = Assembly.GetExecutingAssembly();
                    Type type = findAssembly.GetType(className);
                    return Activator.CreateInstance(type);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor Not Found");
            }
        }
    }


}