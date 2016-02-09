using Bridge;

namespace UnityEngine
{
	[External]
	public struct Vector2
	{
		public float x;
		public float y;


		public Vector2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public static Vector2 operator +(Vector2 c1, Vector2 c2)
		{
			return default(Vector2);
		}
		public static Vector2 operator *(Vector2 c1, float f)
		{
			return default(Vector2);
		}
		public static Vector2 operator *(float f, Vector2 c1)
		{
			return default(Vector2);
		}
	}

	[External]
	public struct Vector3
	{
		public float x;
		public float y;
		public float z;

		public Vector3(float x, float y)
		{
			this.x = x;
			this.y = y;
			this.z = 0;
		}

		public Vector3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public static Vector3 operator +(Vector3 c1, Vector3 c2)
		{
			return default(Vector3);
		}

		public static Vector3 operator *(Vector3 c1, float f)
		{
			return default(Vector3);
		}

		public static Vector3 operator *(float f, Vector3 c1)
		{
			return default(Vector3);
		}

		public static float Distance(Vector3 v1, Vector3 v2)
		{
			return 0;
		}
	}

	[External]
	public struct Rect
	{
		public float x;
		public float y;
		public float width;
		public float height;

		public Rect(float x, float y, float width, float height)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
		}

	}
	
	[External]
	public struct Ray
	{
		
	}

	[External]
	public enum KeyCode
	{
		
	}
	[External]
	public struct Touch
	{
		
	}
	[External]
	public enum TouchPhase
	{
		Began,
		Canceled,
		Ended
	}

	[External]
	public struct Color
	{
		
	}

	[External]
	public struct Bounds
	{
		
	}

	[External]
	public enum TextureWrapMode
	{
		
	}

	[External]
	public enum FilterMode
	{
		
	}

	[External]
	public enum TextureFormat
	{
		
	}

	[External]
	public struct Color32
	{
		
	}

	[External]
	public struct Quaternion
	{
		
	}
}