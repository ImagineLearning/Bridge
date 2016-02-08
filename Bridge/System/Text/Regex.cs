using System.Collections;
using Bridge;

namespace System.Text.RegularExpressions
{
	[External]
	public static class RegexExtensions
	{

	}

	[External]
	public class Regex
	{
		public Regex(string pattern)
		{

		}
		public Regex(string pattern, RegexOptions options)
		{

		}

		public MatchCollection Matches(string text)
		{
			return null;
		}

		public static MatchCollection Matches(string text, string pattern, RegexOptions options = RegexOptions.None)
		{
			return null;
		}

		public bool IsMatch(string text)
		{
			return false;
		}

		public static string Replace(string text, string pattern, MatchEvaluator evaluator, RegexOptions options = RegexOptions.None)
		{
			return null;
		}

		public static string Replace(string text, string pattern, string replacement, RegexOptions options = RegexOptions.None)
		{
			return null;
		}

		public Match Match(string text)
		{
			return null;
		}

		public static Match Match(string text, string pattern, RegexOptions options = RegexOptions.None)
		{
			return null;
		}

		public string Replace(string text, string replacement)
		{
			return null;
		}

		public static string Escape(string text)
		{
			return null;
		}

		public static bool IsMatch(string pattern, string text)
		{
			return false;
		}

		public static string[] Split(string str1, string str2)
		{
			return null;
		}


	}

	[External]
	public class MatchCollection : ICollection
	{
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public int Count { get; private set; }

		public Match this[int i]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}

	[External]
	public class Match
	{
		public string Value { get; private set; }
		public bool Success { get; private set; }
		public int Index { get; private set; }
		public GroupCollection Groups { get; private set; }
		public Match NextMatch()
		{
			return null;
		}
	}

	[External]
	public class GroupCollection : ICollection
	{
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public int Count { get; private set; }

		public Group this[int i]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		//public Group this[string str]
		//{
		//	get
		//	{
		//		return null;
		//	}
		//	set
		//	{
		//	}
		//}
	}

	[External]
	public class Group
	{
		public string Value { get; private set; }
		public CaptureCollection Captures { get; private set; }

	}

	[External]
	public class CaptureCollection : ICollection
	{
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public int Count { get; private set; }

		public Capture this[int i]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}

	[External]
	public class Capture
	{
		public int Index;
	}

	[External]
	public delegate string MatchEvaluator(Match match);


	[External]
	public enum RegexOptions
	{
		None, IgnoreCase, Singleline
	}
}
