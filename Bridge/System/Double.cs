using Bridge;

namespace System
{
    [External]
    public struct Double : IComparable, IComparable<Double>, IEquatable<Double>, IFormattable
    {
        private Double(int i)
        {
        }

        public static readonly double MaxValue = 0;

        public static readonly double MinValue = 0;

        [InlineConst]
        public const double Epsilon = 4.94065645841247E-324;

        public static readonly double NegativeInfinity = 0;

        public static readonly double PositiveInfinity = 0;

        public static readonly double NaN = 0;

        public string Format(string format)
        {
            return null;
        }

        public string Format(string format, IFormatProvider provider)
        {
            return null;
        }

        public string ToString(int radix)
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

        public override string ToString()
        {
            return null;
        }

        public string ToString(IFormatProvider provider)
        {
            return null;
        }

        public static double Parse(string s)
        {
            return 0;
        }

        public static double Parse(string s, IFormatProvider provider)
        {
            return 0;
        }

        public static bool TryParse(string s, out double result)
        {
            result = 0;
            return false;
        }

        public static bool TryParse(string s, IFormatProvider provider, out double result)
        {
            result = 0;
            return false;
        }

        public string ToExponential()
        {
            return null;
        }

        public string ToExponential(int fractionDigits)
        {
            return null;
        }

        public string ToFixed()
        {
            return null;
        }

        public string ToFixed(int fractionDigits)
        {
            return null;
        }

        public string ToPrecision()
        {
            return null;
        }

        public string ToPrecision(int precision)
        {
            return null;
        }

        public static bool IsPositiveInfinity(double d)
        {
            return false;
        }

        public static bool IsNegativeInfinity(double d)
        {
            return false;
        }

        public static bool IsInfinity(double d)
        {
            return false;
        }

        public static bool IsFinite(double d)
        {
            return false;
        }

        public static bool IsNaN(double d)
        {
            return false;
        }

        public int CompareTo(double other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(double other)
        {
            return false;
        }
    }
}
