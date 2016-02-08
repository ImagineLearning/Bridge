using Bridge;

namespace System
{
    [External]
    public struct UInt16 : IComparable, IComparable<UInt16>, IEquatable<UInt16>, IFormattable
    {
        private UInt16(int i)
        {
        }

        [InlineConst]
        public const ushort MinValue = 0;

        [InlineConst]
        public const ushort MaxValue = 65535;

        public static ushort Parse(string s)
        {
            return 0;
        }

        public static ushort Parse(string s, int radix)
        {
            return 0;
        }

        public static bool TryParse(string s, out ushort result)
        {
            result = 0;
            return false;
        }

        public static bool TryParse(string s, out ushort result, int radix)
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

        public int CompareTo(ushort other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(ushort other)
        {
            return false;
        }
    }
}
