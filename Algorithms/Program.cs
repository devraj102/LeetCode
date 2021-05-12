using Algorithms.StringAlgo;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            NaivePatternSearching naivePatternSearching = new NaivePatternSearching();
            naivePatternSearching.NaiveApproach("adqacadad", "ada");
            Console.WriteLine("Hello World!");
        }
    }
}
