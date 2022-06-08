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
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor Not Found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCHMETHOD, "Method Not Found");
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCHCLASS, "Class Not Found");
            }
        }
        public static object CreateMoodAnalyzeWithParamaterConstructor(string className, string constructor, string mood)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructor))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructorInfo.Invoke(new object[] { mood });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Constructor Not Found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Class Not Found");
            }
        }
        public static string InvokeMoodAnalyser(string mood, string methodName)
        {
            try
            {
                Type type = Type.GetType("Mood_Analyser.MoodAnalyser");
                object moodAnalyse = MoodAnalyserFactory.CreateMoodAnalyzeWithParamaterConstructor("Mood_Analyser.MoodAnalyser",
                    "MoodAnalyser", "happy");
                MethodInfo method = type.GetMethod(methodName);
                object chkmood = method.Invoke(moodAnalyse, null);
                return chkmood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Method Not Found");
            }

        }
    }
    }



