using Bridge;

namespace System
{
    [External]
    public struct UInt32 : IComparable, IComparable<UInt32>, IEquatable<UInt32>, IFormattable
    {
        private UInt32(int i)
        {
        }

        [InlineConst]
        public const uint MinValue = 0;

        [InlineConst]
        public const uint MaxValue = 4294967295;

        public static uint Parse(string s)
        {
            return 0;
        }

        public static uint Parse(string s, int radix)
        {
            return 0;
        }

        public static bool TryParse(string s, out uint result)
        {
            result = 0;
            return false;
        }

        public static bool TryParse(string s, out uint result, int radix)
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

        public int CompareTo(uint other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(uint other)
        {
            return false;
        }
    }
}
