using System;
using System.Linq;

namespace AbbaGame.Solutions
{
    public class Frolov : Bench
    {
        public override string CanObtain(string initial, string target)
        {
            bool result = CanObtain_Array(initial, target);

            return result ? "Possible" : "Impossible";
        }

        private bool CanObtain_Array(string initial, string target)
        {
            char[] current = target.ToCharArray();
            char[] start = initial.ToCharArray();
            while (current.Length > start.Length)
            {
                var lastChar = current[^1];
                current = current[0..^1];
                if (lastChar == 'B')
                {
                    Array.Reverse(current);
                }
            }

            return current.SequenceEqual(start);
        }
    }
}