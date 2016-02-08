using Bridge;

namespace System
{
    [External]
    [IgnoreCast]
    public class Object
    {
        public virtual object this[string name]
        {
            [External]
            get
            {
                return null;
            }
            [External]
            set
            {
            }
        }

        public virtual extern string ToString();

        public virtual extern string ToLocaleString();

        public virtual extern object ValueOf();

        public virtual extern bool HasOwnProperty(object v);

        public virtual extern bool IsPrototypeOf(object v);

        public virtual extern bool PropertyIsEnumerable(object v);

        public extern Type GetType();

        public static extern bool ReferenceEquals(object a, object b);

        public virtual extern bool Equals(object o);

        public static extern bool Equals(object a, object b);

        public virtual extern int GetHashCode();

        public static extern string[] Keys(object obj);

        public static extern string[] GetOwnPropertyNames(object obj);

        public static extern dynamic GetPrototype<T>();

        public readonly Type Constructor;

        public virtual extern dynamic ToDynamic();

        public virtual extern string GetClassName();
    }

    [External]
    public static class ObjectExtensions
    {
        public static extern T As<T>(this object obj);

        public static extern T Cast<T>(this object obj);

        public static extern T TryCast<T>(this object obj) where T : class;

        public static extern bool Is<T>(this object obj);
    }
}
