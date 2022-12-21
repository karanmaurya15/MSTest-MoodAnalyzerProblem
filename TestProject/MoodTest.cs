using MSTest_MoodAnalyzerProblem;

namespace TestProject
{
    [TestClass]
    public class AnalyzeMoodTest
    {
        [TestMethod]
        public void TestHappyOrSad()
        {
            MoodAnalyzer mood = new MoodAnalyzer("Happy"); // Arrange
            string result = mood.AnalyzeMood(); // Act
            Assert.AreEqual("Happy".ToUpper(), result); //Assert
        }
        [TestMethod]
        public void GivenSad_ReturnSad()
        {
            MoodAnalyzer mood = new MoodAnalyzer("I am in Sad Mood");
            string result = mood.AnalyzeMood();
            Assert.AreEqual("Sad".ToUpper(), result);
        }
        [TestMethod]
        public void GivenAny_ReturnHappy()
        {
            MoodAnalyzer mood = new MoodAnalyzer("I am in Any Mood");
            string result = mood.AnalyzeMood();
            Assert.AreEqual("Happy".ToUpper(), result);
        }
        [TestMethod]
        public void GivenNull_ReturnHappy()
        {
            MoodAnalyzer mood = new MoodAnalyzer(null);
            string result = mood.AnalyzeMood(); 
            Assert.AreEqual("Happy".ToUpper(), result);
        }
    }
}