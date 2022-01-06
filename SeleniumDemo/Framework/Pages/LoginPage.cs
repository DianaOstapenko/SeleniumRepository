using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumDemo
{
	public class LoginPage
	{
			public LoginPage()
			{
			}


			[FindsBy(How = How.XPath, Using = "//a[@class='login']")]
			public IWebElement SighInButton;

			[FindsBy(How = How.XPath, Using = "//input[@id='email']")]
			public IWebElement EmailTxtBox;

			[FindsBy(How = How.XPath, Using = "//input[@id='passwd']")]
			public IWebElement PasswordTxtBox;

			[FindsBy(How = How.XPath, Using = "//button[@id='SubmitLogin']")]
			public IWebElement SubmitButton;

			[FindsBy(How = How.XPath, Using = "//a[@class='account']")]
			public IWebElement LoggedUserButton;

	}
}
