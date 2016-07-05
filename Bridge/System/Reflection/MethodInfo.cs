using Bridge;

namespace System.Reflection
{
	[External]
	public class MethodInfo : IBridgeClass
	{
		public string Name { get; }

		public extern object Invoke(object obj, object[] parameters);
	}
}
