using Bridge;

namespace System
{
    [External]
    public struct Int32 : IComparable, IComparable<Int32>, IEquatable<Int32>, IFormattable
    {
        private Int32(int i)
        {
        }

        [InlineConst]
        public const int MinValue = -2147483648;

        [InlineConst]
        public const int MaxValue = 2147483647;

        public static int Parse(string s)
        {
            return 0;
        }

        public static int Parse(string s, int radix)
        {
            return 0;
        }

        public static bool TryParse(string s, out int result)
        {
            result = 0;
            return false;
        }

        public static bool TryParse(string s, out int result, int radix)
        {
            result = 0;
            return false;
        }

		[Template("toString()")]
	    public override string ToString()
	    {
		    return null;
	    }
		
		[Template("toString({0})")]
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

		[Template("toString({0})")]
        public string ToString(string format)
        {
            return null;
        }

		[Template("toString({0})")]
        public string ToString(string format, IFormatProvider provider)
        {
            return null;
        }

        public int CompareTo(int other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(int other)
        {
            return false;
        }
    }
}
