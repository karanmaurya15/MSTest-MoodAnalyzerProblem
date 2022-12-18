using System.Threading.Channels;

namespace MSTest_MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Mood Analyzer Problem\n");

            Console.WriteLine("Enter String to check Mood");
            string mood = Console.ReadLine();
            MoodAnalyzer analyzer = new MoodAnalyzer(mood);
            Console.WriteLine(analyzer.AnalyzeMood());
        }
    }
    public class MoodAnalyzer
    {
        string msg;
        public MoodAnalyzer()
        { 
        }
        public MoodAnalyzer(string msg)
        {
            this.msg = msg;
        }
        public string AnalyzeMood()
        {
            try
            {
                bool mood1 = msg.Contains("Happy", StringComparison.OrdinalIgnoreCase);
                if (mood1)
                {
                    return "HAPPY";
                }
                bool mood2 = msg.Contains("Sad", StringComparison.OrdinalIgnoreCase);
                if (mood2)
                {
                    return "SAD";
                }
                return "HAPPY";
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}