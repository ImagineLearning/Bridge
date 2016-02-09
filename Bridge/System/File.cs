using Bridge;

namespace System.IO
{
	[External]
	public static class File
	{
		public static bool Exists(string path)
		{
			return false;
		}

		public static void WriteAllBytes(string path, byte[] bytes)
		{
			
		}

		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		public static bool Delete(string path)
		{
			return false;
		}

		public static string GetFileNameWithoutExtension(string path)
		{
			return null;
		}

		public static string GetExtension(string path)
		{
			return null;
		}

		public static Stream OpenRead(string path)
		{
			return null;
		}

		public static Stream OpenWrite(string path)
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

		public static void SetReadOnly(string path, bool isReadOnly)
		{
			
		}

		public static bool IsDirectory(string path)
		{
			return false;
		}

		public static DateTime GetLastWriteTime(string path)
		{
			return default(DateTime);
		}

		public static string[] ReadAllLines(string path)
		{
			return null;
		}
		public static string ReadAllText(string path)
		{
			return null;
		}

		public static void Append(string path, string text)
		{
			
		}

		public static void Move(string sourceFileName, string destinationFileName)
		{
			
		}

		public static Stream Open(string path, FileMode fileMode, FileAccess fileAccess, FileShare fileShare)
		{
			return null;
		}

		public static Stream Open(string path, FileMode fileMode)
		{
			return null;
		}

		public static FileAttributes GetAttributes(string path)
		{
			return default(FileAttributes);
		}

		public static void SetAttributes(string path, FileAttributes attributes)
		{
			
		}
	}

	[External]
	public class FileInfo
	{
		public FileInfo()
		{
			
		}

		public FileInfo(string path)
		{
			
		}

		public string Name { get; private set; }

		public long Length { get; private set; }
	}

	[External]
	public static class Path
	{
		public static string GetFileNameWithoutExtension(string path)
		{
			return null;
		}

		public static string GetExtension(string path)
		{
			return null;
		}

		public static string Combine(string path1, string path2)
		{
			return null;
		}

		public static string GetFileName(string path)
		{
			return null;
		}

		public static char[] GetInvalidPathChars()
		{
			return null;
		}
	}

}