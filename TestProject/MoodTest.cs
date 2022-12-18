using MSTest_MoodAnalyzerProblem;

namespace TestProject
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void MoodTester()
        {
            MoodAnalyzer obj = new MoodAnalyzer("Happy"); // Arrange

            string result = obj.AnalyzeMood(); // Act

            Assert.AreEqual("Happy".ToUpper(), result); //Assert
        }
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
            MoodAnalyzer mood = new MoodAnalyzer("I am in Any Mood");
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Happy".ToUpper(), result);
        }
        [TestMethod]
        public void GivenNull()
        {
            MoodAnalyzer mood = new MoodAnalyzer(null);
            string result = mood.AnalyzeMood();

            Assert.AreEqual("Happy".ToUpper(), result);
        }
    }
}