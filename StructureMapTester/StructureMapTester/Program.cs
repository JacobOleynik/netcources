using System;
using StructureMapTester.Core;
using StructureMapTester.IoC;

namespace StructureMapTester
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//Try to comment the line below and compare the results
			Application.Initialize(ConfigurationHelper.ConfigureDependencies);

			try
			{
				var runner = new MessageRunner(Application.Current.Container.GetInstance<IMessenger>());
				runner.Run();
			}
			catch (Exception ex)
			{
				Console.WriteLine("There was an exception of {0} type", ex.GetType());
			}
		}
	}
}
