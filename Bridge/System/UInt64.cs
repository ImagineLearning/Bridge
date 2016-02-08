using Bridge;

namespace System
{
    [External]
    public struct UInt64 : IComparable, IComparable<UInt64>, IEquatable<UInt64>, IFormattable
    {
        private UInt64(int i)
        {
        }

        [InlineConst]
        public const ulong MinValue = 0;

        [InlineConst]
        public const ulong MaxValue = 9007199254740991;

        public static ulong Parse(string s)
        {
            return 0;
        }

        public static ulong Parse(string s, int radix)
        {
            return 0;
        }

        public static bool TryParse(string s, out ulong result)
        {
            result = 0;
            return false;
        }

        public static bool TryParse(string s, out ulong result, int radix)
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

        public int CompareTo(ulong other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(ulong other)
        {
            return false;
        }
    }
}
