using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FinalTest
{
    public class BaseClass
    {
        public static IWebDriver driver;

        public static void SeleniumInit()
        {
            var driver2 = new ChromeDriver();
            driver = driver2;
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        }

        public static void WriteMethod(By by, string text)
        {
            driver.FindElement(by).SendKeys(text);
        }
        public static void ClickMethod(By by)
        {
            driver.FindElement(by).Click();
        }
    }
}
