using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest_MoodAnalyzerProblem
{
    public class MoodAnalysisExceptions : Exception
    {
        public MoodAnalysisExceptions(string message) : base(message)
        {

        }
    }
}
