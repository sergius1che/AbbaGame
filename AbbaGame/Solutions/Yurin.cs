using System.Linq;

namespace AbbaGame.Solutions
{
    public class Yurin : Bench
    {
        public override string CanObtain(string initial, string target)
        {
            var targetArray = target.ToArray();

            for (var i = targetArray.Length; i > initial.Length; i--)
            {
                if (targetArray[i - 1] == 'B')
                {
                    Remove_B(targetArray, i);
                }
            }
            if (CompareTo(initial, targetArray))
            {
                return "Possible";
            }
            else
            {
                return "Impossible";
            }
        }

        static void Remove_B(char[] targetArray, int currentLength)
        {
            for (var i = 0; i < currentLength / 2; i++)
            {
                char buffer = targetArray[i];
                targetArray[i] = targetArray[currentLength - 2 - i];
                targetArray[currentLength - 2 - i] = buffer;
            }
        }

        static bool CompareTo(string initial, char[] target)
        {
            for (var i = 0; i < initial.Length; i++)
            {
                if (initial[i] != target[i])
                {
                    return false;
                }
            }
            return true;
        }
    }

}
