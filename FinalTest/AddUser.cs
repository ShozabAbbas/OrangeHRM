using System;
using OpenQA.Selenium;

namespace FinalTest
{
    public class AddUser : BaseClass
    {
        By ClickAdd = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[1]/button");
        By ClickUsername = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[1]/div/div[2]/div/div/div[2]/i");
        By selectusrname = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[1]/div/div[2]/div/div[2]/div[3]");
        By empname = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input");
        By selectempname = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div[2]/div[1]/span");
        By status = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div/div[2]/i");
        By selectstatus = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div[2]/div[2]");
        By writeusername = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input");
        By password = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[1]/div/div[2]/input");
        By confirmpassword = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[2]/div/div[2]/input");
        By SaveBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[3]/button[2]");




        public void Add_usr(IWebDriver driver)
        {
            ClickMethod(ClickAdd);
            Thread.Sleep(3000);
            ClickMethod(ClickUsername);
            ClickMethod(selectusrname);
            WriteMethod(empname,"s");
            Thread.Sleep(2000);
            ClickMethod(selectempname);
            Thread.Sleep(3000);
            ClickMethod(status);
            Thread.Sleep(2000);
            ClickMethod(selectstatus);
            WriteMethod(writeusername, "Alpha01");
            Thread.Sleep(2000);
            WriteMethod(password, "a123456");
            WriteMethod(confirmpassword, "a123456");
            ClickMethod(SaveBtn);
            Thread.Sleep(5000);






        }
    }
}
