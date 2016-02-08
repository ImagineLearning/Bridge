using Bridge;

namespace System
{
    [External]
    public struct Single : IComparable, IComparable<Single>, IEquatable<Single>, IFormattable
    {
        private Single(int i)
        {
        }

        [InlineConst]
        public const float MaxValue = (float)3.40282346638528859e+38;

        [InlineConst]
        public const float MinValue = (float)-3.40282346638528859e+38;

        [InlineConst]
        public const float Epsilon = (float)1.4e-45;

        public static readonly float NaN = 0;

        public static readonly float NegativeInfinity = 0;

        public static readonly float PositiveInfinity = 0;

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

        public static float Parse(string s)
        {
            return 0;
        }

        public static float Parse(string s, IFormatProvider provider)
        {
            return 0;
        }

        public static bool TryParse(string s, out float result)
        {
            result = 0;
            return false;
        }

        public static bool TryParse(string s, IFormatProvider provider, out float result)
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

        public static bool IsPositiveInfinity(float d)
        {
            return false;
        }

        public static bool IsNegativeInfinity(float d)
        {
            return false;
        }

        public static bool IsInfinity(float d)
        {
            return false;
        }

        public static bool IsFinite(float d)
        {
            return false;
        }

        public static bool IsNaN(float d)
        {
            return false;
        }

        public int CompareTo(float other)
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }

        public bool Equals(float other)
        {
            return false;
        }
    }
}
