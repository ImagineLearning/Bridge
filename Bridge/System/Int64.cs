using Bridge;

namespace System
{
    [External]
    public struct Int64 : IComparable, IComparable<Int64>, IEquatable<Int64>, IFormattable
    {
        private Int64(int i)
        {
        }

        [InlineConst]
        public const long MinValue = -9007199254740991;

        [InlineConst]
        public const long MaxValue = 9007199254740991;

        public static long Parse(string s)
        {
            return 0;
        }

        public static long Parse(string s, int radix)
        {
            return 0;
        }

        public static bool TryParse(string s, out long result)
        {
            result = 0;
            return false;
        }

        public static bool TryParse(string s, out long result, int radix)
        {
            result = 0;
            return false;
        }

        public string ToString(int radix)
        {
            return null;
        }

        public string Format(string format)
        {
            return null;
        }

        public string Format(string format, IFormatProvider provider)
        {
            return null;
        }

        public string ToString(string format)
        {
            return null;
        }

        public string ToString(string format, IFormatProvider provider)
        {
            return null;
        }

        public int CompareTo(long other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(long other)
        {
            return false;
        }
    }
}
