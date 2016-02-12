using System;

namespace Test
{
	public class EventTest
	{
		public event EventHandler Completed;

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

		private void OnCompleted(object sender, EventArgs eventArgs)
		{
			throw new NotImplementedException();
		}
	}

	public class AnotherClass
	{
		public EventTest EventTest;

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

		private void EventTestOnCompleted(object sender, EventArgs eventArgs)
		{
			throw new NotImplementedException();
		}
	}
}
