using NUnit.Framework;

namespace SeleniumDemo
{
	public class Tests: TestBase
	{

		[Test]
		public void Test1()
		{
			string userEmail = "tasgveryuncucnaafu@kvhrs.com";
			string userPassword = "123456789";
			string authorizedUser = "Test Test";

			Pages.LoginPage.SighInButton.Click();
			Pages.LoginPage.EmailTxtBox.SendKeys(userEmail);
			Pages.LoginPage.PasswordTxtBox.SendKeys(userPassword);
			Pages.LoginPage.SubmitButton.Click();

			string loggedUserName = Pages.LoginPage.LoggedUserButton.Text;
			loggedUserName.Equals(authorizedUser);
		}

	}
}
