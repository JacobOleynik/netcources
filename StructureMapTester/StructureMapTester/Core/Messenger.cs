using System;

namespace StructureMapTester.Core
{
	public class Messenger : IMessenger
	{
		public void ShowSuccessMessage()
		{
			Console.WriteLine("You did this :-)");
		}
	}
}
