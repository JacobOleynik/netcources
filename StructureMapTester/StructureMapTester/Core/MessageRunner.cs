namespace StructureMapTester.Core
{
	public class MessageRunner
	{
		private readonly IMessenger messenger;

		public MessageRunner(IMessenger messenger)
		{
			this.messenger = messenger;
		}

		public void Run()
		{
			messenger.ShowSuccessMessage();
		}
	}
}
