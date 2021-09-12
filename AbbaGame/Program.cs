using System.Linq;

namespace AbbaGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutions = typeof(Program).Assembly.GetTypes()
                .Where(x => x.IsClass && !x.IsAbstract)
                .Where(x => x.GetInterfaces().Any(x => x.Equals(typeof(ISolution))))
                .ToArray();

            var simplePassed = SimpleTestsExecutor.Instance.Execute(solutions);

#if RELEASE
            if (simplePassed)
            {
                var bench = new BenchmarkSwitcher(solutions);
                bench.RunAllJoined();
            }
#endif

            StrongTestsExecutor.Instance.Execute(solutions);
        }
    }
}
