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
            _ = CanObtain(INPUT, TARGET);
        }

        public abstract string CanObtain(string initial, string target);
    }
}
