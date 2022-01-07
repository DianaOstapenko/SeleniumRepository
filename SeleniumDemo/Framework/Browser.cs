using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo.Framework
{
	public static class Browser
		{
			public static IWebDriver WebDriver;
			private static Settings _settings = new Settings();

			public static void Initialize()
			{
				WebDriver = new ChromeDriver(@"C:\webdrivers");
				WebDriver.Navigate().GoToUrl(_settings.Host);
				WebDriver.Manage().Window.Maximize();
				System.Threading.Thread.Sleep(2000);
			}

			public static ISearchContext Driver => WebDriver;

			public static void Close()
			{
				WebDriver.Close();
				WebDriver.Quit();
			}

		}
	}