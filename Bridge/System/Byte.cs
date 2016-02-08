using Bridge;

namespace System
{
    [External]
    public struct Byte : IComparable, IComparable<Byte>, IEquatable<Byte>, IFormattable
    {
        private Byte(int i)
        {
        }

        [InlineConst]
        public const byte MinValue = 0;

        [InlineConst]
        public const byte MaxValue = 255;

        public static byte Parse(string s)
        {
            return 0;
        }

        public static byte Parse(string s, int radix)
        {
            return 0;
        }

        public static bool TryParse(string s, out byte result)
        {
            result = 0;
            return false;
        }

        public static bool TryParse(string s, out byte result, int radix)
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

        public int CompareTo(byte other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(byte other)
        {
            return false;
        }
    }
}
