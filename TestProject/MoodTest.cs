using MSTest_MoodAnalyzerProblem;
using Newtonsoft.Json;

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
        // TC-3.1
        [TestMethod]
        public void CustomExceptions_GivenNull_ThrowNull()
        {
            MoodAnalyzer mood = new MoodAnalyzer(null);
            string result = mood.AnalyzeMood();
            Assert.AreEqual(MoodAnalysisErrors.Null.ToString(), result);
        }
        // TC-3.2
        [TestMethod]
        public void CustomExceptions_GivenEmpty_ThrowEmpty()
        {
            MoodAnalyzer mood = new MoodAnalyzer(" ");
            string result = mood.AnalyzeMood(); 
            Assert.AreEqual(MoodAnalysisErrors.Empty.ToString(), result);
        }
        // TC-4.1
        [TestMethod]
        public void CreateMoodAnalyzerObject_DefaultConstructor_UsingReflection()
        {
            MoodAnalyzer objMood = new MoodAnalyzer();
            var objFactory = MoodAnalyzerFactory.CreateInstance("MoodAnalyzer");
            objMood.Equals(objFactory);
        }
        // TC-4.2
        [TestMethod]
        public void CreateMoodAnalyzerObject_DefaultConstructor_UsingReflection_GivenImproperClass_ReturnNoSuchClass()
        {
            var objFactory = (string)MoodAnalyzerFactory.CreateInstance("MoodAnalyzer");
            Assert.AreEqual(MoodAnalysisErrors.NO_SUCH_CLASS.ToString(), objFactory);
        }
        // TC-4.3
        [TestMethod]
        public void CreateMoodAnalyzerObject_DefaultConstructor_UsingReflectionException_GivenImproperConstructor_ReturnNoSuchMethod()
        {
            var objFactory = (string)MoodAnalyzerFactory.CreateInstance("MoodAnalyzer", "MoodAnalyzerFactory");
            Assert.AreEqual(MoodAnalysisErrors.NO_SUCH_METHOD.ToString(), objFactory);
        }
        // TC-5.1
        [TestMethod]
        public void CreateMoodAnalyzerObject_ParameterConstructor_UsingReflection()
        {
            object objMood = new MoodAnalyzer("HAPPY");
            string exp = JsonConvert.SerializeObject(objMood);
            object objFactory = MoodAnalyzerFactory.CreateInstanceParameterConstructor("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer", "HAPPY");
            string actual = JsonConvert.SerializeObject(objFactory);
            Assert.AreEqual(exp, actual);
        }
        // TC-5.2
        [TestMethod]
        public void CreateMoodAnalyzerObject_ParameterConstructor_UsingReflectionException_GivenImproperClass_ReturnNoSuchClass()
        {
            MoodAnalyzer objMood = new MoodAnalyzer("HAPPY");
            var objFactory = MoodAnalyzerFactory.CreateInstanceParameterConstructor("MoodAnalyzerProblem.MoodAnalyzers", "MoodAnalyzer", "HAPPY");
            Assert.AreEqual(MoodAnalysisErrors.NO_SUCH_CLASS.ToString(), objFactory);
        }
        // TC-5.3
        [TestMethod]
        public void CreateMoodAnalyzerObject_ParameterConstructor_UsingReflectionException_GivenImproperConstructor_ReturnNoSuchMethod()
        {
            MoodAnalyzer objMood = new MoodAnalyzer("HAPPY");
            var objFactory = (string)MoodAnalyzerFactory.CreateInstanceParameterConstructor("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyser", "HAPPY");
            Assert.AreEqual(MoodAnalysisErrors.NO_SUCH_CONSTRUCTOR.ToString(), objFactory);
        }
        // TC-6.1
        [TestMethod]
        public void InvokeMethod_GivenHappy_ReturnHappy()
        {
            string expected = "HAPPY";
            string actual = MoodAnalyzerFactory.InvokeMethod("AnalyzeMood", "HAPPY");
            Assert.AreEqual(expected, actual);
        }
        // TC-6.2
        [TestMethod]
        public void InvokeMethod_GivenImproperMethod_ReturnException()
        {
            string expected = MoodAnalysisErrors.NO_SUCH_METHOD.ToString();
            string actual = MoodAnalyzerFactory.InvokeMethod("Analyze", MoodAnalysisErrors.NO_SUCH_METHOD.ToString());
            Assert.AreEqual(expected, actual);
        }
        // TC-7.1
        [TestMethod]
        public void ChangeMoodDynamically_GivenHappy_ReturnHappy()
        {
            string expected = "HAPPY";
            string actual = MoodAnalyzerFactory.ChangeMoodDynamically("message", "HAPPY");
            Assert.AreEqual(expected, actual);
        }
        // TC-7.2
        [TestMethod]
        public void ChangeMoodDynamically_GivenImproperField_ReturnException()
        {
            string expected = MoodAnalysisErrors.NO_SUCH_FIELD.ToString();
            string actual = MoodAnalyzerFactory.ChangeMoodDynamically("messageWrong", MoodAnalysisErrors.NO_SUCH_FIELD.ToString());
            Assert.AreEqual(expected, actual);
        }
        // TC-7.3
        [TestMethod]
        public void ChangeMoodDynamically_GivenNull_ReturnNull()
        {
            string expected = MoodAnalysisErrors.Null.ToString();
            string actual = MoodAnalyzerFactory.ChangeMoodDynamically("message", null);
            Assert.AreEqual(expected, actual);
        }
    }
}