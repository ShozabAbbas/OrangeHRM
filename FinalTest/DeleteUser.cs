using System;
using OpenQA.Selenium;

namespace FinalTest
{
    public class DeleteUser : BaseClass
    {
        By searchusername = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/input");
        By ClickSearch = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]");
        By selectradioBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div[2]/div/div/div[1]/div/div/label/span/i");
        By deleteselectedBtn = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[2]/div/div/button");
        By confirmDeletion = By.XPath("//*[@id=\"app\"]/div[3]/div/div/div/div[3]/button[2]");


        public void del_usr(IWebDriver driver)
        {

            WriteMethod(searchusername, Keys.Command + "A");
            WriteMethod(searchusername, "Alpha01");
            Thread.Sleep(2000);
            ClickMethod(ClickSearch);
            Thread.Sleep(2000);
            ClickMethod(selectradioBtn);
            Thread.Sleep(2000);
            ClickMethod(deleteselectedBtn);
            ClickMethod(confirmDeletion);
            Thread.Sleep(2000);

        }
    }
}
