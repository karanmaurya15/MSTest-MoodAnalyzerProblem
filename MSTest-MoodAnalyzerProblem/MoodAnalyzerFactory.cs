using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MSTest_MoodAnalyzerProblem
{
    public class MoodAnalyzerFactory
    {
        public MoodAnalyzerFactory()
        {

        }
        public static object CreateInstance(string className, [Optional] string constructorName)
        {
            try
            {
                Type type = Type.GetType(className);
                if (type == null)
                {
                    throw new MoodAnalysisExceptions(MoodAnalysisErrors.NO_SUCH_CLASS.ToString());
                }
                else if (constructorName != null)
                {
                    bool exists = false;
                    var constructors = type.GetConstructors();
                    foreach (var constructor in constructors)
                    {
                        if (constructor.ToString() == constructorName)
                        {
                            exists = true;
                            continue;
                        }
                    }
                    if (!exists)
                    {
                        throw new MoodAnalysisExceptions(MoodAnalysisErrors.NO_SUCH_METHOD.ToString());
                    }
                }
                return type;
            }
            catch (MoodAnalysisExceptions ex)
            {
                return ex.Message;
            }
        }
    }
}
