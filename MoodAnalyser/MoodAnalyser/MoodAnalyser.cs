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
        public MoodAnalyser(string mood)
        {
            this.mood = mood;
        }
        public string AnalyseMood()
        {
            if (this.mood.Contains("sad"))
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

    }
}

