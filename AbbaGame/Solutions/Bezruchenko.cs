using System;
using System.Collections.Generic;

namespace AbbaGame.Solutions
{
    public class Bezruchenko : Bench
    {
        public override string CanObtain(string initial, string target)
        {
            LazyString lazyInit = new LazyString(initial);
            LazyString lazyTarget = new LazyString(target);

            foreach (int start in lazyTarget.FindAll(lazyInit))
            {
                LazyString slice = new LazyString(target, start, start + initial.Length - 1);
                if (TryObtain(slice))
                    return "Possible";
            }

            foreach (int start in lazyTarget.FindAll(lazyInit.Reversed()))
            {
                LazyString slice = new LazyString(target, start, start + initial.Length);
                if (slice.At(initial.Length) == 'B')
                {
                    slice.Reverse();
                    if (TryObtain(slice))
                        return "Possible";
                }
            }

            return "Impossible";
        }

        protected bool TryObtain(LazyString slice)
        {
            //Console.WriteLine(slice);
            if (slice.ContainsAllData)
                return true;

            if (slice.At(slice.Length) == 'A' &&
                TryObtain(new LazyString(slice, 0, slice.Length)))
                return true;

            if (slice.At(-1) == 'B' &&
                TryObtain(new LazyString(slice, -1, slice.Length - 1).Reversed()))
                return true;

            return false;
        }
    }

    // почти уверен, что что-то подобное уже в шарпе есть, но я не нашёл
    public class LazyString
    {
        protected readonly string data;
        protected int start;
        protected int end;
        protected bool isReversed;

        public int Length => end - start + 1;

        public bool ContainsAllData => start == 0 && end == data.Length - 1;


        public LazyString(string data)
        {
            this.data = data;
            start = 0;
            end = data.Length - 1;
            isReversed = false;
        }

        public LazyString(string data, int start, int end)
        {
            this.data = data;
            this.start = start;
            this.end = end;
            isReversed = false;
        }

        public LazyString(LazyString other, int start, int end)
        {
            this.data = other.data;
            isReversed = other.isReversed;

            if (isReversed)
            {
                this.end = other.end - start;
                this.start = other.end - end;
            }
            else
            {
                this.start = other.start + start;
                this.end = other.start + end;
            }
        }

        public void Reverse()
        {
            isReversed = !isReversed;
        }

        public LazyString Reversed()
        {
            isReversed = !isReversed;
            return this;
        }

        public char At(int index)
        {
            int accessIndex;
            if (!isReversed)
            {
                accessIndex = start + index;
            }
            else
            {
                accessIndex = end - index;
            }

            if (accessIndex < 0 || accessIndex >= data.Length)
                return '\0';

            return data[accessIndex];
        }

        public override string ToString()
        {
            if (Length < 0)
                return "";
            string res = data.Substring(start, this.Length);
            if (isReversed)
            {
                char[] charArray = res.ToCharArray();
                Array.Reverse(charArray);
                res = new string(charArray);
            }

            return res;
        }

        public static bool operator ==(LazyString left, LazyString right)
        {
            if (left.Length != right.Length)
                return false;

            for (int i = 0; i < left.Length; i++)
            {
                if (left.At(i) != right.At(i))
                    return false;
            }
            return true;
        }

        public static bool operator !=(LazyString left, LazyString right) => !(left == right);

        public IEnumerable<int> FindAll(LazyString T)
        {
            // Алгоритм Кнута-Морриса-Пратта
            // https://neerc.ifmo.ru/wiki/index.php?title=%D0%90%D0%BB%D0%B3%D0%BE%D1%80%D0%B8%D1%82%D0%BC_%D0%9A%D0%BD%D1%83%D1%82%D0%B0-%D0%9C%D0%BE%D1%80%D1%80%D0%B8%D1%81%D0%B0-%D0%9F%D1%80%D0%B0%D1%82%D1%82%D0%B0
            int pl = T.Length;
            int tl = this.Length;
            List<int> answer = new List<int>();
            int[] p = PrefixFunction(new LazyString(T.ToString() + "#" + this.ToString()));
            for (int i = 0; i < tl; i++)
            {
                if (p[pl + i + 1] == pl)
                {
                    answer.Add(i - pl + 1);
                }
            }
            return answer;
        }

        protected int[] PrefixFunction(LazyString str)
        {
            // https://neerc.ifmo.ru/wiki/index.php?title=%D0%9F%D1%80%D0%B5%D1%84%D0%B8%D0%BA%D1%81-%D1%84%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F
            int[] p = new int[str.Length];
            p[0] = 0;
            for (int i = 1; i < str.Length; i++)
            {
                int k = p[i - 1];
                while (k > 0 && str.At(i) != str.At(k))
                {
                    k = p[k - 1];
                }

                if (str.At(i) == str.At(k))
                {
                    k++;
                }
                p[i] = k;
            }
            return p;
        }

    }
}
