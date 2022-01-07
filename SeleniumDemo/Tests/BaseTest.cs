using NUnit.Framework;
using SeleniumDemo.Framework;

namespace SeleniumDemo.Tests
{
	[TestFixture]
	public class TestBase
	{
		[SetUp]
		public static void Initialize()
		{
			Browser.Initialize();
		}

		[TearDown]
		public static void TestFixtureTearDown()
		{
			Browser.Close();
		}

		private static Settings _settings = new Settings();
		public static Settings Settings { get { return _settings; } }

	}
}