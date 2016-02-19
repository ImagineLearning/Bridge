using Bridge;

namespace System
{
    [External]
    public struct Int16 : IComparable, IComparable<Int16>, IEquatable<Int16>, IFormattable
    {
        private Int16(int i)
        {
        }

        [InlineConst]
        public const short MinValue = -32768;

        [InlineConst]
        public const short MaxValue = 32767;

        public static short Parse(string s)
        {
            return 0;
        }

        public static short Parse(string s, int radix)
        {
            return 0;
        }

        public static bool TryParse(string s, out short result)
        {
            result = 0;
            return false;
        }

        public static bool TryParse(string s, out short result, int radix)
        {
            result = 0;
            return false;
        }

		[Template("toString()")]
		public override string ToString()
		{
			return null;
		}

		[Template("toString({0}")]
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

		[Template("toString({0}")]
        public string ToString(string format)
        {
            return null;
        }

		[Template("toString({0}")]
        public string ToString(string format, IFormatProvider provider)
        {
            return null;
        }

        public int CompareTo(short other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(short other)
        {
            return false;
        }
    }
}
