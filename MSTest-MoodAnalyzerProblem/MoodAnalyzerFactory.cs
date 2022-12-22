using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest_MoodAnalyzerProblem
{
    public class MoodAnalyzerFactory
    {
        public static Type CreateInstance(string className)
        {
            Type type = Type.GetType(className);
            return type;
        }
    }
}
