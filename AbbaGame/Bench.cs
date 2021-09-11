using BenchmarkDotNet.Attributes;

namespace AbbaGame
{
    [MemoryDiagnoser]
    public abstract class Bench : ISolution
    {
        private const string INPUT = "BBBBABABBBBBBA";
        private const string TARGET = "BBBBABABBABBBBBBABABBBBBBBBABAABBBAA";

        [Benchmark]
        public void Run()
        {
            _ = СanObtain(INPUT, TARGET);
        }

        public abstract string СanObtain(string initial, string target);
    }
}
