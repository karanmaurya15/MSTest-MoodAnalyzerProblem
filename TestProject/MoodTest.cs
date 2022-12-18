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

            Assert.AreEqual("Happy", result); //Assert
        }
    }
}