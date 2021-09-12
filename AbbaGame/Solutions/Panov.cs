using System;
using System.Linq;

namespace AbbaGame.Solutions
{
    public class Panov : Bench
    {
        public const string CAN_OBTAIN = "Possible";
        public const string CANT_OBTAIN = "Impossible";

        public override string CanObtain(string initial, string target)
        {
            if (!CanContinue(initial, target))
            {
                return CANT_OBTAIN;
            }

            return Abba(initial, target);
        }

        private static string Abba(string initial, string target)
        {
            if (initial.Length < target.Length)
            {
                var strWithA = initial + "A";
                if (CanContinue(strWithA, target))
                {
                    return Abba(strWithA, target);
                }

                var strWithB = new string(initial.Reverse().ToArray()) + "B";
                if (CanContinue(strWithB, target))
                {
                    return Abba(strWithB, target);
                }

                return CANT_OBTAIN;
            }
            return CAN_OBTAIN;
        }

        private static bool CanContinue(string current, string target)
        {
            var reverse = new string(target.Reverse().ToArray());
            return target.Contains(current) || reverse.Contains(current);
        }
    }
}
