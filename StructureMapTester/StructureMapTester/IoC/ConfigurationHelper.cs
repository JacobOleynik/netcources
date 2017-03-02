using StructureMap;
using StructureMapTester.Core;

namespace StructureMapTester.IoC
{
	public class ConfigurationHelper
	{
		public static void ConfigureDependencies(ConfigurationExpression x)
		{
			x.For<IMessenger>().Use<Messenger>();
		}
	}
}
