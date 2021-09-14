using System;
using System.Text;

namespace AbbaGame.Solutions
{
    public class Borisov : Bench
    {
        public override string CanObtain(string initial, string target)
        {
            if (IsPossible(initial, target))
                return "Possible";
            else
                return "Impossible";
        }

        private static bool IsPossible(string initial, string target)
        {
            if (initial == target)
            {
                return true;
            }

            if (initial.Length >= target.Length)
            {
                return false;
            }

            StringBuilder sb = new StringBuilder(target);
            while (initial.Length != sb.Length)
            {
                char targetLastChar = sb[sb.Length - 1];
                if (targetLastChar == 'A')
                {
                    unApplyA(sb);
                }
                else if (targetLastChar == 'B')
                {
                    unApplyRevB(sb);
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Unknown symbol {targetLastChar}");
                }
            }

            return initial == sb.ToString();
        }

        private static void unApplyA(StringBuilder sb)
        {
            sb.Remove(sb.Length - 1, 1);
        }

        private static void unApplyRevB(StringBuilder sb)
        {
            sb = sb.Remove(sb.Length - 1, 1);
            sb.Reverse();
        }
    }

    public static class StringBuilderExtension
    {
        public static void Reverse(this StringBuilder sb)
        {
            char t;
            int end = sb.Length - 1;
            int start = 0;

            while (end - start > 0)
            {
                t = sb[end];
                sb[end] = sb[start];
                sb[start] = t;
                start++;
                end--;
            }
        }
    }
}
