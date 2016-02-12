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
}
