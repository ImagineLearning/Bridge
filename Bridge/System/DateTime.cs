using Bridge;

namespace System
{
    [External]
    public struct DateTime : IComparable, IComparable<DateTime>, IEquatable<DateTime>, IFormattable
    {
        public static readonly DateTime MaxValue = new DateTime(123);

        public static readonly DateTime MinValue = new DateTime(0);

        /// <summary>
        /// Double value representing the number of milliseconds since 1 January 1970 00:00:00 UTC (Unix Epoch).
        /// </summary>
        /// <param name="value">The numberof milliseconds since 1 January 1970 00:00:00 UTC (Unix Epoch)</param>
        public DateTime(long value)
        {
        }

        /// <summary>
        /// String value representing a date. The string should be in a format recognized by the Date.parse() method (IETF-compliant RFC 2822 timestamps and also a version of ISO8601).
        /// </summary>
        /// <param name="dateString"></param>
        public DateTime(string dateString)
        {
        }

        public DateTime(int year, int month)
        {
        }

        public DateTime(int year, int month, int day)
        {
        }

        public DateTime(int year, int month, int day, int hours)
        {
        }

        public DateTime(int year, int month, int day, int hours, int minutes)
        {
        }

        public DateTime(int year, int month, int day, int hours, int minutes, int seconds)
        {
        }

        public DateTime(int year, int month, int day, int hours, int minutes, int seconds, int milliseconds)
        {
        }

        public static long Utc(int year, int month, int day, int hours, int minutes, int seconds, int ms)
        {
            return 0;
        }

        public static long Utc(int year, int month, int day, int hours, int minutes, int seconds)
        {
            return 0;
        }

        public static long Utc(int year, int month, int day, int hours, int minutes)
        {
            return 0;
        }

        public static long Utc(int year, int month, int day, int hours)
        {
            return 0;
        }

        public static long Utc(int year, int month, int day)
        {
            return 0;
        }

        public static long Utc(int year, int month)
        {
            return 0;
        }

        public static DateTime Now
        {
            get
            {
                return default(DateTime);
            }
        }

        public static DateTime UtcNow
        {
            get
            {
                return default(DateTime);
            }
        }

        public static DateTime Today
        {
            get
            {
                return default(DateTime);
            }
        }

        public string Format(string format)
        {
            return null;
        }

        public string Format(string format, IFormatProvider provider)
        {
            return null;
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

        public int GetDate()
        {
            return 0;
        }

        public int GetDay()
        {
            return 0;
        }

        public int GetFullYear()
        {
            return 0;
        }

        public int GetHours()
        {
            return 0;
        }

        public int GetMilliseconds()
        {
            return 0;
        }

        public int GetMinutes()
        {
            return 0;
        }

        public int GetMonth()
        {
            return 0;
        }

        public int GetSeconds()
        {
            return 0;
        }

        public long GetTime()
        {
            return 0;
        }

        public int GetTimezoneOffset()
        {
            return 0;
        }

        public int GetUtcDate()
        {
            return 0;
        }

        public int GetUtcDay()
        {
            return 0;
        }

        public int GetUtcFullYear()
        {
            return 0;
        }

        public int GetUtcHours()
        {
            return 0;
        }

        public int GetUtcMilliseconds()
        {
            return 0;
        }

        public int GetUtcMinutes()
        {
            return 0;
        }

        public int GetUtcMonth()
        {
            return 0;
        }

        public int GetUtcSeconds()
        {
            return 0;
        }

        public static DateTime Parse(string value)
        {
            return default(DateTime);
        }

        public static DateTime Parse(string value, IFormatProvider provider)
        {
            return default(DateTime);
        }

        public static DateTime Parse(string value, IFormatProvider provider, bool utc)
        {
            return default(DateTime);
        }

        public static DateTime Parse(string value, bool utc)
        {
            return default(DateTime);
        }

        public static bool TryParse(string value, out DateTime result)
        {
            result = default(DateTime);
            return false;
        }

        public static bool TryParse(string value, out DateTime result, bool utc)
        {
            result = default(DateTime);
            return false;
        }

        public static bool TryParse(string value, IFormatProvider provider, out DateTime result)
        {
            result = default(DateTime);
            return false;
        }

        public static bool TryParse(string value, IFormatProvider provider, out DateTime result, bool utc)
        {
            result = default(DateTime);
            return false;
        }

        public static DateTime ParseExact(string value, string format)
        {
            return default(DateTime);
        }

        public static DateTime ParseExact(string value, string format, bool utc)
        {
            return default(DateTime);
        }

        public static DateTime ParseExact(string value, string[] formats)
        {
            return default(DateTime);
        }

        public static DateTime ParseExact(string value, string[] formats, bool utc)
        {
            return default(DateTime);
        }

        public static DateTime ParseExact(string value, string format, IFormatProvider provider)
        {
            return default(DateTime);
        }

        public static DateTime ParseExact(string value, string format, IFormatProvider provider, bool utc)
        {
            return default(DateTime);
        }

        public static DateTime ParseExact(string value, string[] formats, IFormatProvider provider)
        {
            return default(DateTime);
        }

        public static DateTime ParseExact(string value, string[] formats, IFormatProvider provider, bool utc)
        {
            return default(DateTime);
        }

        public static bool TryParseExact(string value, string format, out DateTime result)
        {
            result = default(DateTime);
            return false;
        }

        public static bool TryParseExact(string value, string format, out DateTime result, bool utc)
        {
            result = default(DateTime);
            return false;
        }

        public static bool TryParseExact(string value, string[] formats, out DateTime result)
        {
            result = default(DateTime);
            return false;
        }

        public static bool TryParseExact(string value, string[] formats, out DateTime result, bool utc)
        {
            result = default(DateTime);
            return false;
        }

        public static bool TryParseExact(string value, string format, IFormatProvider provider, out DateTime result)
        {
            result = default(DateTime);
            return false;
        }

        public static bool TryParseExact(string value, string format, IFormatProvider provider, out DateTime result, bool utc)
        {
            result = default(DateTime);
            return false;
        }

        public static bool TryParseExact(string value, string[] formats, IFormatProvider provider, out DateTime result)
        {
            result = default(DateTime);
            return false;
        }

        public static bool TryParseExact(string value, string[] formats, IFormatProvider provider, out DateTime result, bool utc)
        {
            result = default(DateTime);
            return false;
        }

        public string ToDateString()
        {
            return null;
        }

        public string ToLocaleDateString()
        {
            return null;
        }

        public string ToLocaleTimeString()
        {
            return null;
        }

        public string ToTimeString()
        {
            return null;
        }

        public string ToUtcString()
        {
            return null;
        }

        public static DateTime operator -(DateTime d, TimeSpan t)
        {
            return default(DateTime);
        }

        public static DateTime operator +(DateTime d, TimeSpan t)
        {
            return default(DateTime);
        }

        public static TimeSpan operator -(DateTime a, DateTime b)
        {
            return default(TimeSpan);
        }

        public TimeSpan Subtract(DateTime value)
        {
            return default(TimeSpan);
        }

        public static bool operator ==(DateTime a, DateTime b)
        {
            return false;
        }

        public static bool operator !=(DateTime a, DateTime b)
        {
            return false;
        }

        public static bool operator <(DateTime a, DateTime b)
        {
            return false;
        }

        public static bool operator >(DateTime a, DateTime b)
        {
            return false;
        }

        public static bool operator <=(DateTime a, DateTime b)
        {
            return false;
        }

        public static bool operator >=(DateTime a, DateTime b)
        {
            return false;
        }

        public static explicit operator DateTime(Date dt)
        {
            return default(DateTime);
        }

        public static explicit operator Date(DateTime dt)
        {
            return null;
        }

        public DateTime Date
        {
            get
            {
                return default(DateTime);
            }
        }

        public int Day
        {
            get
            {
                return 0;
            }
        }

        public DayOfWeek DayOfWeek
        {
            get
            {
                return 0;
            }
        }

        public int DayOfYear
        {
            get
            {
                return 0;
            }
        }

        public int Hour
        {
            get
            {
                return 0;
            }
        }

        public int Millisecond
        {
            get
            {
                return 0;
            }
        }

        public int Minute
        {
            get
            {
                return 0;
            }
        }

        public int Month
        {
            get
            {
                return 0;
            }
        }

        public int Second
        {
            get
            {
                return 0;
            }
        }

        public int Year
        {
            get
            {
                return 0;
            }
        }

        public DateTime AddDays(double value)
        {
            return default(DateTime);
        }

        public DateTime AddHours(double value)
        {
            return default(DateTime);
        }

        public DateTime AddMilliseconds(double value)
        {
            return default(DateTime);
        }

        public DateTime AddMinutes(double value)
        {
            return default(DateTime);
        }

        public DateTime AddMonths(int months)
        {
            return default(DateTime);
        }

        public DateTime AddSeconds(double value)
        {
            return default(DateTime);
        }

        public DateTime AddYears(int value)
        {
            return default(DateTime);
        }

        public static int DaysInMonth(int year, int month)
        {
            return 0;
        }

        public static bool IsLeapYear(int year)
        {
            return false;
        }

        public int CompareTo(DateTime other)
        {
            return 0;
        }

        public int CompareTo(object other)
        {
            return 0;
        }

        public static int Compare(DateTime t1, DateTime t2)
        {
            return 0;
        }

        public bool Equals(DateTime other)
        {
            return false;
        }

        public static bool Equals(DateTime t1, DateTime t2)
        {
            return false;
        }

        public bool IsDaylightSavingTime()
        {
            return false;
        }

        public DateTime ToUniversalTime()
        {
            return default(DateTime);
        }

        public DateTime ToLocalTime()
        {
            return default(DateTime);
        }

        public extern DateTime Add(TimeSpan value);

        public extern DateTime AddTicks(long value);

        public extern DateTime Subtract(TimeSpan value);

        public TimeSpan TimeOfDay
        {
            get
            {
                return default(TimeSpan);
            }
        }

        public long Ticks
        {
            get
            {
                return 0;
            }
        }
    }
}
