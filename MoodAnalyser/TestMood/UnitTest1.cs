namespace TestMood
{
    public class Tests
    {
        

        [Test]
        public void GivenMood_CheckMood_ReturnResultAsSad()
        {
            Mood_Analyser.MoodAnalyser checkMood = new Mood_Analyser.MoodAnalyser();
            string actualResult = checkMood.AnalyseMood("I am in sad mood");
            Assert.AreEqual("Sad", actualResult);
        }

    }
}