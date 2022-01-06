using SeleniumExtras.PageObjects;

namespace SeleniumDemo
{
	public static class Pages
		{
			private static T GetPage<T>() where T : new()
			{
				var page = new T();
				PageFactory.InitElements(Browser.Driver, page);
				return page;
			}

		public static LoginPage LoginPage => GetPage<LoginPage>();
	}
}