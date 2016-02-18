using System;

namespace Test
{
	public class EventTest
	{
		public event EventHandler Completed;
		public int MyInt;

		public void FireCompleted()
		{
			Completed(this, new EventArgs());
		}

		public void AddEventHandler()
		{
			Completed += OnCompleted;
		}

		public void RemoveEventHandler()
		{
			Completed -= OnCompleted;
		}

		public void AddEventHandlerDelegate()
		{
			Completed += delegate
			{
				throw new NotImplementedException();
			};
		}

		public void AddEventHandlerDelegateWithStuff()
		{
			Completed += delegate
			{
				var s = MyInt.ToString();
			};
		}

		private void OnCompleted(object sender, EventArgs eventArgs)
		{
			throw new NotImplementedException();
		}
	}

	public class AnotherClass
	{
		public EventTest EventTest;
		public int MyInt;

		public void AddEventHandler()
		{
			EventTest.Completed += EventTestOnCompleted;
		}

		public void RemoveEventHandler()
		{
			EventTest.Completed -= EventTestOnCompleted;
		}

		public void AddEventHandlerDelegate()
		{
			EventTest.Completed += delegate
			{
				throw new NotImplementedException();
			};
		}

		public void AddEventHandlerDelegateWithStuff()
		{
			EventTest.Completed += delegate
			{
				var s = MyInt.ToString();
			};
		}

		private void EventTestOnCompleted(object sender, EventArgs eventArgs)
		{
			throw new NotImplementedException();
		}
	}
}
