using Bridge;

namespace System
{
    [External]
    public abstract class Enum : ValueType
    {
        public static extern Enum Parse(Type enumType, string value);

        public static extern Enum Parse(Type enumType, string value, bool ignoreCase);

        public static extern string ToString(Type enumType, Enum value);

        public static extern Array GetValues(Type enumType);

        public extern int CompareTo(object target);

        public static extern string Format(Type enumType, object value, string format);

        public static extern string GetName(Type enumType, object value);

        public static extern string[] GetNames(Type enumType);

        public extern bool HasFlag(Enum flag);

        public static extern bool IsDefined(Type enumType, object value);

        public static extern bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct;

        public static extern bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct;

        public override extern string ToString();
    }
}
