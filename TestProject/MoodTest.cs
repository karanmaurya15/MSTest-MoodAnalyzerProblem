using MSTest_MoodAnalyzerProblem;

namespace TestProject
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void MoodTester()
        {
            MoodAnalyzer obj = new MoodAnalyzer(); // Arrange

            string result = obj.AnalyzeMood("Happy"); // Act

            Assert.AreEqual("Happy".ToUpper(), result); //Assert
        }
        [TestMethod]
        public void ReturnSad()
        {
            MoodAnalyzer mood = new MoodAnalyzer();
            string result = mood.AnalyzeMood("I am in Sad Mood");

            Assert.AreEqual("Sad".ToUpper(), result);
        }
        [TestMethod]
        public void ReturnHappy()
        {
            MoodAnalyzer mood = new MoodAnalyzer();
            string result = mood.AnalyzeMood("I am in Any Mood");

            Assert.AreEqual("Happy".ToUpper(), result);
        }
    }
}