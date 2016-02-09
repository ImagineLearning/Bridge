using Bridge;

namespace System.IO
{
	[External]
	public static class Directory
	{
		public static bool Exists(string path)
		{
			return false;
		}

		public static void CreateDirectory(string path)
		{
		}

		public static void Delete(string path, bool recursive)
		{
			
		}

		public static string GetName(string path)
		{
			return null;
		}

		public static string[] GetFiles(string path)
		{
			return null;
		}

		public static string[] GetFiles(string path, string pattern)
		{
			return null;
		}

		public static string[] GetFiles(string path, string pattern, SearchOption searchOption)
		{
			return null;
		}

		public static string[] GetDirectories(string path)
		{
			return null;
		}

		public static void Copy(string source, string destination, bool overwrite)
		{
			
		}

		public static long GetSize(string path)
		{
			return 0;
		}

		public static string GetCurrentDirectory()
		{
			return null;
		}

		public static DirectoryInfo GetParent(string path)
		{
			return null;
		}
	}

	[External]
	public class DirectoryInfo
	{
		public DirectoryInfo()
		{
			
		}
		public DirectoryInfo(string path)
		{
			
		}
		public string Name { get; private set; }
		public string FullName { get; private set; }
	}

}