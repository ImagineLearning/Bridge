using Bridge;

namespace System
{
    [External]
    public struct SByte : IComparable, IComparable<SByte>, IEquatable<SByte>, IFormattable
    {
        private SByte(int i)
        {
        }

        [InlineConst]
        public const sbyte MinValue = -128;

        [InlineConst]
        public const sbyte MaxValue = 127;

        public static sbyte Parse(string s)
        {
            return 0;
        }

        public static sbyte Parse(string s, int radix)
        {
            return 0;
        }

        public static bool TryParse(string s, out sbyte result)
        {
            result = 0;
            return false;
        }

        public static bool TryParse(string s, out sbyte result, int radix)
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

        public int CompareTo(sbyte other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(sbyte other)
        {
            return false;
        }
    }
}
