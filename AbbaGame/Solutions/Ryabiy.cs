using System;

namespace AbbaGame.Solutions
{
    public class Ryabiy : Bench
    {
        public override string CanObtain(string initial, string target)
        {
            var span = target.ToCharArray().AsSpan();

            while (span.Length > initial.Length)
            {
                if (span[^1] == 'A')
                {
                    span = span[..^1];
                }
                else
                {
                    span = span[..^1];
                    span.Reverse();
                }
            }

            return MemoryExtensions.Equals(span, initial, StringComparison.Ordinal)
                ? "Possible"
                : "Impossible";
        }
    }
}
