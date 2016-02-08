using Bridge;

namespace System
{
    [External]
    public struct Char : IComparable, IComparable<Char>, IEquatable<Char>, IFormattable
    {
        private Char(int i)
        {
        }

        [InlineConst]
        public const char MinValue = '\0';

        [InlineConst]
        public const char MaxValue = '\xFFFF';

        public string Format(string format)
        {
            return null;
        }

        public string Format(string format, IFormatProvider provider)
        {
            return null;
        }

        public static char Parse(string s)
        {
            return '\0';
        }

        public override string ToString()
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

        public int CompareTo(char other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(char other)
        {
            return false;
        }

        public static bool IsLower(char ch)
        {
            return false;
        }

        public static bool IsUpper(char ch)
        {
            return false;
        }

        public static char ToLower(char ch)
        {
            return (char)0;
        }

        public static char ToUpper(char ch)
        {
            return (char)0;
        }

        public static bool IsLetter(char ch)
        {
            return false;
        }

        public static bool IsLetter(string s, int index)
        {
            return false;
        }

        public static bool IsDigit(char ch)
        {
            return false;
        }

        public static bool IsDigit(string s, int index)
        {
            return false;
        }

        public static bool IsLetterOrDigit(char ch)
        {
            return false;
        }

        public static bool IsLetterOrDigit(string s, int index)
        {
            return false;
        }

        public static bool IsWhiteSpace(char ch)
        {
            return false;
        }

        public static bool IsWhiteSpace(string s, int index)
        {
            return false;
        }

        public static bool IsHighSurrogate(char ch)
        {
            return false;
        }

        public static bool IsHighSurrogate(string s, int index)
        {
            return false;
        }

        public static bool IsLowSurrogate(char ch)
        {
            return false;
        }

        public static bool IsLowSurrogate(string s, int index)
        {
            return false;
        }

        public static bool IsSurrogate(char ch)
        {
            return false;
        }

        public static bool IsSurrogate(string s, int index)
        {
            return false;
        }

        public static bool IsSurrogatePair(char ch1, char ch2)
        {
            return false;
        }

        public static bool IsSurrogatePair(string s, int index)
        {
            return false;
        }

        public static bool IsSymbol(char ch)
        {
            return false;
        }

        public static bool IsSymbol(string s, int index)
        {
            return false;
        }

        public static bool IsSeparator(char ch)
        {
            return false;
        }

        public static bool IsSeparator(string s, int index)
        {
            return false;
        }

        public static bool IsPunctuation(char ch)
        {
            return false;
        }

        public static bool IsPunctuation(string s, int index)
        {
            return false;
        }

        public static bool IsNumber(char ch)
        {
            return false;
        }

        public static bool IsNumber(string s, int index)
        {
            return false;
        }

        public static bool IsControl(char ch)
        {
            return false;
        }

        public static bool IsControl(string s, int index)
        {
            return false;
        }
    }
}
