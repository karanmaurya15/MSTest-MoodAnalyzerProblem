using MSTest_MoodAnalyzerProblem;

namespace TestProject
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void ReturnSad()
        {
            MoodAnalyzer mood = new MoodAnalyzer("I am in Sad Mood");
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Sad".ToUpper(), result);
        }
        [TestMethod]
        public void ReturnHappy()
        {
            MoodAnalyzer mood = new MoodAnalyzer("I am in Happy Mood");
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Happy".ToUpper(), result);
        }
    }
}