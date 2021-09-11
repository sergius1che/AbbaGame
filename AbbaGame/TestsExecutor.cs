using System;
using System.Collections.Generic;

namespace AbbaGame
{
    public abstract class TestsExecutor
    {
        protected const string POSSIBLE = "Possible";
        protected const string IMPOSSIBLE = "Impossible";

        public abstract List<(string Initial, string Target, string Result)> Cases { get; }

        public bool Execute(params Type[] solutions)
        {
            var passed = true;

            foreach (var solution in solutions)
            {
                WriteLGreen($"Start tests for {solution.Name}'s solution;");
                passed &= ExecuteInternal(solution);
            }

            return passed;
        }

        protected void WriteLGreen(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        protected void WriteLRed(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        private bool ExecuteInternal(Type solution)
        {
            var passed = true;
            var instance = (ISolution)Activator.CreateInstance(solution);

            foreach (var @case in Cases)
            {
                var result = instance.СanObtain(@case.Initial, @case.Target);

                var currentPassed = result == @case.Result;

                if (!currentPassed)
                {
                    WriteLRed($"Test fail! Initial: {@case.Initial}, Target: {@case.Target}, Expect result: {@case.Result}");
                }

                passed &= currentPassed;
            }

            if (passed)
            {
                WriteLGreen("Tests passed.");
            }

            return passed;
        }
    }
}
