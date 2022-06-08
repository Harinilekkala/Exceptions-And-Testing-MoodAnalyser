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
            try
            {


                Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser(null);
                string actualResult = checkMood.AnalyseMood();
                Assert.AreNotEqual("Happy", actualResult);

            }

            catch (Exception ex)
            {
                Assert.AreEqual("Mood Should not be null", ex.Message);
            }

        }
        [Test]
        public void GivenMoodNull_WhenCheckMood_ThenThrowException()
        {
            try
            {
                Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser(null);
                string actualResult = checkMood.AnalyseMood();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Mood Should not be null", ex.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyserClassName_ReturnMoodAnalyserObject()
        {

            object expected = new Mood_Analyser.MoodAnalyser(null);
            object actual = Mood_Analyser.MoodAnalyserFactory.CreateMoodAnalyze("Mood_Analyser.MoodAnalyser", "Mood_Analyser.MoodAnalyser");
            expected.Equals(actual);
           
        }

        
        
    }
}