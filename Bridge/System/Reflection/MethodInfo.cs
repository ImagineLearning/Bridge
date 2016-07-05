using Bridge;

namespace System.Reflection
{
	[External]
	public class MethodInfo : IBridgeClass
	{
		public string Name { get; private set; }

		public extern object Invoke(object obj, object[] parameters);
	}
}
