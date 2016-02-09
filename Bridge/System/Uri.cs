using Bridge;

namespace System
{

	[External]
	public class Uri
	{
		public Uri()
		{
			
		}

		public Uri(string uri)
		{
			
		}

		public Uri(string part1, string part2)
		{
			
		}

		public Uri(Uri baseUri, string part2)
		{
			
		}

		public static bool IsWellFormedUriString(string uri, UriKind kind)
		{
			return false;
		}

		public string Scheme { get; private set; }

		public static string EscapeUriString(string uri)
		{
			return null;
		}

		public string AbsoluteUri { get { return null; } }
	}

	[External]
	public enum UriKind { Absolute, Relative }

	//[External]
	//public class Guid
	//{
		
	//}

}