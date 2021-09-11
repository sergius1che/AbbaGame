using System;

namespace AbbaGame.Solutions
{
    public class Chechin : Bench
    {
        private const string POSSIBLE = "Possible";
        private const string IMPOSSIBLE = "Impossible";

        public override string СanObtain(string initial, string target)
        {
            var i = new Span<char>(initial.ToCharArray());
            var t = new Span<char>(target.ToCharArray());

            if (Can(i, t))
            {
                return POSSIBLE;
            }

            return IMPOSSIBLE;
        }

        private bool Can(Span<char> initial, Span<char> target)
        {
            if (target.SequenceEqual(initial))
            {
                return true;
            }

            if (!Contain(initial, target))
            {
                return false;
            }

            var actionA = ActionA(initial);
            var actionB = ActionB(initial);

            return Can(actionA, target) || Can(actionB, target);
        }

        /// <summary>
        /// Добавляем 'A'
        /// </summary>
        private Span<char> ActionA(Span<char> span)
        {
            Span<char> newSpan = new char[span.Length + 1];

            span.CopyTo(newSpan);
            newSpan[span.Length] = 'A';

            return newSpan;
        }

        /// <summary>
        /// Переворачиваем и добавляем 'B'
        /// </summary>
        private Span<char> ActionB(Span<char> span)
        {
            Span<char> newSpan = new char[span.Length + 1];

            span.Reverse();
            span.CopyTo(newSpan);
            newSpan[span.Length] = 'B';

            return newSpan;
        }

        /// <summary>
        /// Проверяет содержится ли sub в target в прямом и перевёрнутом виде, не переворачивая sub.
        /// </summary>
        private bool Contain(Span<char> sub, Span<char> target)
        {
            for (int i = 0; i <= target.Length - sub.Length; i++)
            {
                bool res;

                if (target[i] == sub[0])
                {
                    res = true;

                    for (int k = 1; k < sub.Length && res; k++)
                    {
                        res &= sub[k] == target[i + k];
                    }

                    if (res)
                    {
                        return true;
                    }
                }

                if (target[i] == sub[sub.Length - 1])
                {
                    res = true;

                    for (int k = sub.Length - 2; k >= 0 && res; k--)
                    {
                        res &= sub[k] == target[i + sub.Length - 1 - k];
                    }

                    if (res)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
