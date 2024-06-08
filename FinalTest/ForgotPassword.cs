using System;
using OpenQA.Selenium;

namespace FinalTest
{
	public class ForgotPassword:BaseClass
	{
		By ClickForgotPass = By.XPath("/html/body/div/div[1]/div/div[1]/div/div[2]/div[2]/form/div[4]/p");
		By Enterusername = By.CssSelector("#app > div.orangehrm-forgot-password-container > div.orangehrm-forgot-password-wrapper > div > form > div.oxd-form-row > div > div:nth-child(2) > input");
		By ClickResetPassword = By.XPath("/html/body/div/div[1]/div[1]/div/form/div[2]/button[2]");

        public void F_Password(IWebDriver driver, string uname)
		{
			Thread.Sleep(5000);
			ClickMethod(ClickForgotPass);
			Thread.Sleep(5000);
			WriteMethod(Enterusername, uname);
			ClickMethod(ClickResetPassword);
		}
	}
}

