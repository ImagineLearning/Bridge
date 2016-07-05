using System.Reflection;
using Bridge;

namespace System
{
    [External]
    [Name("Function")]
    public class Type
	{
		public string Name { get; private set; }
		public extern MethodInfo[] GetMethods();
		public static extern Type GetTypeFromHandle(RuntimeTypeHandle typeHandle);
    }

    [External]
    [Name("Object")]
    public class ValueType
    {
    }

    [External]
    [Name("Object")]
    public struct IntPtr
    {
    }

    [External]
    [Name("Object")]
    public struct UIntPtr
    {
    }

    [External]
    [Name("Object")]
    public class ParamArrayAttribute
    {
    }

    [External]
    [Name("Object")]
    public struct RuntimeTypeHandle
    {
    }

    [External]
    [Name("Object")]
    public struct RuntimeFieldHandle
    {
    }
}
