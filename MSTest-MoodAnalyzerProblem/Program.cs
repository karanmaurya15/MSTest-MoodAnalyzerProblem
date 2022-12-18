﻿using System.Threading.Channels;

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
            bool mood1 = msg.Contains("Happy");
            if (mood1)
            {
                return "Happy";
            }
            bool mood2 = msg.Contains("Sad");
            if (mood2)
            {
                return "Sad";
            }
            return null;
        }
    }
}