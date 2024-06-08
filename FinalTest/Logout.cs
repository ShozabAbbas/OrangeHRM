using System;
using OpenQA.Selenium;

namespace FinalTest
{

    public class Signout : BaseClass
    {
        By Logout = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[2]/ul/li/span/p");

        public void lout(IWebDriver driver)
        {
            ClickMethod(Logout);
        }
    }
}



