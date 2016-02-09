using System;
using Bridge;

namespace UnityEngine
{
	[External]
	public class Transform
	{
		
	}

	[External]
	public class GameObject
	{
		
	}

	[External]
	public class Object
	{
		
	}

	[External]
	public class AccelerationEvent
	{
		
	}

	[External]
	public class Texture2D
	{
		
	}

	[External]
	public class AudioClip
	{
		
	}

	[External]
	public class Camera
	{
		public static Camera main { get; private set; }

		public Vector2 ViewportToWorldPoint(Vector2 viewportPoint)
		{
			return default(Vector2);
		}
		public Vector2 ViewportToWorldPoint(Vector3 viewportPoint)
		{
			return default(Vector2);
		}
	}

	[External]
	public static class Mathf
	{
		public static float Pow(float num, int pow)
		{
			return 0;
		}

		public static float Abs(float num)
		{
			return 0;
		}

		public static float Min(float num1, float num2)
		{
			return 0;
		}

		public static float Max(float num1, float num2)
		{
			return 0;
		}

		public static float PI { get; private set; }

		public static float Sin(float num)
		{
			return 0;
		}

		public static float Cos(float num)
		{
			return 0;
		}

		public static float Sqrt(float num1)
		{
			return 0;
		}
	}

	[External]
	public static class Resources
	{
		public static Object[] FindObjectsOfTypeAll(Type type)
		{
			return null;
		}
	}

}