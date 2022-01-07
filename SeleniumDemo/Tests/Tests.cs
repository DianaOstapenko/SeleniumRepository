using NUnit.Framework;
using SeleniumDemo.Framework.Pages;

namespace SeleniumDemo.Tests
{
	public class Tests: TestBase
	{

		[Test]
		public void Test1()
		{
			string authorizedUser = "Test Test";

			Pages.LoginPage.SighInButton.Click();
			Pages.LoginPage.EmailTxtBox.SendKeys(Settings.UserName);
			Pages.LoginPage.PasswordTxtBox.SendKeys(Settings.Password);
			Pages.LoginPage.SubmitButton.Click();

			string loggedUserName = Pages.LoginPage.LoggedUserButton.Text;
			loggedUserName.Equals(authorizedUser);
		}

	}
}
