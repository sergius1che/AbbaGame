using System.Collections.Generic;

namespace AbbaGame
{
    public sealed class SimpleTestsExecutor : TestsExecutor
    {
        private List<(string Initial, string Target, string Result)> _cases = new List<(string Initial, string Target, string Result)>
        {
            ("B", "ABBA", POSSIBLE),
            ("AB", "ABB", IMPOSSIBLE),
            ("BBAB", "ABABABABB", IMPOSSIBLE),
            ("BBBBABABBBBBBA", "BBBBABABBABBBBBBABABBBBBBBBABAABBBAA", POSSIBLE),
            ("A", "BB", IMPOSSIBLE),
        };

        private SimpleTestsExecutor()
        {
        }

        public static TestsExecutor Instance => new SimpleTestsExecutor();

        public override List<(string Initial, string Target, string Result)> Cases => _cases;
    }
}
