using System;
using OpenQA.Selenium;

namespace FinalTest
{
    public class Signin : BaseClass
    {
        By Name = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/div[2]/input");
        By Password = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[2]/div/div[2]/input");
        By ClickLogin = By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button");

        public void login(IWebDriver driver, string username, string password)
        {
            Thread.Sleep(5000);
            WriteMethod(Name, username);
            WriteMethod(Password, password);
            ClickMethod(ClickLogin);
        }
    }
}