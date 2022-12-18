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
            MoodAnalyzer analyzer = new MoodAnalyzer();
            Console.WriteLine(analyzer.AnalyzeMood(mood));
        }
    }
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string msg)
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
    }
}