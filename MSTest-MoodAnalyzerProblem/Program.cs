using System.Threading.Channels;

namespace MSTest_MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter String to check Mood");
            string mood = Console.ReadLine();
            MoodAnalyzer analyzer = new MoodAnalyzer(mood);
            Console.WriteLine(analyzer.AnalyzeMood());
        }
    }
}