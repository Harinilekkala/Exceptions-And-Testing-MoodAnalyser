namespace TestMood
{
    public class Tests
    {
        

        [Test]
        public void GivenMood_CheckMood_ReturnResultAsSad()
        {
            Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser("I am in sad mood");
            string actualResult = checkMood.AnalyseMood();
            Assert.AreEqual("Sad", actualResult);
        }
        [Test]
        public void GivenMood_CheckMood_ReturnResultAsHappy()
        {
            Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser("I am in Any mood");
            string actualResult = checkMood.AnalyseMood();
            Assert.AreNotEqual("Sad", actualResult);
        }
        [Test]
        public void GivenMoodNull_CheckMood_ReturnResultAsHappy()
        {
            Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser(null);
            string actualResult = checkMood.AnalyseMood();
            Assert.AreNotEqual("Sad", actualResult);
        }

    }
}