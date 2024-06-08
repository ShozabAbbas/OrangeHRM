using System;
using OpenQA.Selenium;

namespace FinalTest
{
    public class ClickAdmin : BaseClass
    {
        By ClickMainAdmin = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a");
        By enterusrname = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/input");
        By Clickuserrole = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[2]/div/div[2]/div/div/div[2]/i");
        By selectkey = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[2]/div/div[2]/div/div[2]/div[3]");
        By employeename = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[3]/div/div[2]/div/div/input");
        By selectempoption = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[3]/div/div[2]/div/div[2]/div[1]/span");
        By selectStatus = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[4]/div/div[2]/div/div/div[2]/i");
        By selectstatusfromdropdown = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[4]/div/div[2]/div/div[2]/div[2]");
        By search = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]");

        public void AdminAccess(IWebDriver driver)
        {
            ClickMethod(ClickMainAdmin);
            Thread.Sleep(3000);
            WriteMethod(enterusrname,"Mehdi");
            Thread.Sleep(3000);
            ClickMethod(Clickuserrole);
            Thread.Sleep(3000);
            ClickMethod(selectkey);
            Thread.Sleep(2000);
            WriteMethod(employeename, "s");
            Thread.Sleep(2000);
            ClickMethod(selectempoption);
            ClickMethod(selectStatus);
            ClickMethod(selectstatusfromdropdown);
            ClickMethod(search);

        }
    }
}

