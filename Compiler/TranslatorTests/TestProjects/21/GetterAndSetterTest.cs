using System;
using Bridge;

namespace Test
{
	public class GetterSetterTest
	{
		private int _myLocalProp = 0;
		public int MyInt { get; set; }
		public bool MyBool { get; private set; }
		public int MyLocalProperty { get { return _myLocalProp; } set { _myLocalProp = value; } }

		public void Test1()
		{
			var i = MyInt;
			MyInt = 20;

			var myLocalProperty = MyLocalProperty;
			MyLocalProperty = 5;
		}

		public void Test2()
		{
			var isTrue = MyBool;
			MyBool = true;
		}
	}

	public class AnotherClass
	{
		public GetterSetterTest GetterSetterTest;

		public void Test3()
		{
			var i = GetterSetterTest.MyInt;
			GetterSetterTest.MyInt = 20;

			var myLocalProperty = GetterSetterTest.MyLocalProperty;
			GetterSetterTest.MyLocalProperty = 5;
		}

		public void Test4()
		{
			var isTrue = GetterSetterTest.MyBool;
		}
	}

	[External]
	public class StateManager
	{
		private int _interaction;
		public int Interaction { get { return _interaction; } }
		public bool SomethingToSet { get; set; }
	}

	[External]
	public abstract class Activity
	{
		public StateManager StateManager { get; private set; }
	}

	public class MyCoolActivity : Activity
	{
		private int _myLocalProp = 0;
		public int MyLocalProperty { get {return _myLocalProp;} set { _myLocalProp = value; } }
		public bool AnotherProperty { get; set; }

		private Icon _currentIcon;

		public Icon CurrentIcon
		{
			get { return _currentIcon; }
			set { _currentIcon = value; }
		}

		private int _num;
		public int Num { set { _num = value; } }

		public void Test5()
		{
			var interaction = this.StateManager.Interaction;
			interaction = StateManager.Interaction;
		}

		public void Test6()
		{
			var local = MyLocalProperty;
			var l = _myLocalProp;
		}

		public void Test7()
		{
			var anotherProperty = AnotherProperty;
		}

		public void Test8()
		{
			StateManager.SomethingToSet = true;
			MyLocalProperty = 5;
			AnotherProperty = true;
		}

		public void Test12()
		{
			_currentIcon.Anim1.Visible = true;
			CurrentIcon.Anim1.Visible = false;
		}

		public void Test13()
		{
			Num = 100;

			CurrentIcon.OnShow += CurrentIconOnOnShow;
		}

		private void CurrentIconOnOnShow(object sender, EventArgs eventArgs)
		{
			throw new NotImplementedException();
		}


		public class Icon
		{
			public AnimationWithSound Anim1 { get; set; }
			public event EventHandler OnShow;
		}

		public class AnimationWithSound
		{
			private IAnimation Animation { get; set; }
			public bool Visible
			{
				set { Animation.Visible = value; }
			}
		}

		[External]
		public interface IAnimation
		{
			bool Visible { get; set; }
		}
	}

	public class Test_MyCoolActivity : MyCoolActivity
	{
		public void Test9()
		{
			var local = MyLocalProperty;
			var interaction = StateManager.Interaction;
		}

		public void Test10()
		{
			var anotherProperty = AnotherProperty;
		}

		public void Test11()
		{
			StateManager.SomethingToSet = true;
			MyLocalProperty = 5;
			AnotherProperty = true;
		}
	}
}
