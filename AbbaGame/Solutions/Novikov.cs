using System;

namespace AbbaGame.Solutions
{
    public class Novikov : Bench
    {
        public override string CanObtain(string initial, string target)
        {
            var targetCharArray = target.ToCharArray();

            for (int i = target.Length - 1; i > initial.Length - 1; i--)
            {
                if (targetCharArray[i] == 'A')
                {
                    Array.Resize(ref targetCharArray, targetCharArray.Length - 1);
                }
                else if (targetCharArray[i] == 'B')
                {
                    Array.Resize(ref targetCharArray, targetCharArray.Length - 1);
                    Array.Reverse(targetCharArray);
                }

            }

            if (new string(targetCharArray) == initial)
            {
                return "Possible";
            }
            else
            {
                return "Impossible";
            }
        }
    }
}
