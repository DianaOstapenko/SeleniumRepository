using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo
{
	public static class Browser
		{
			public static IWebDriver WebDriver; 
			private const string BaseUrl = "http://automationpractice.com/index.php";

			public static void Initialize()
			{
				WebDriver = new ChromeDriver(@"C:\webdrivers");
				WebDriver.Navigate().GoToUrl(BaseUrl);
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