using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FinalTest;

public class Test : BaseClass

{
    [SetUp]
    public void Setup()
    {
        SeleniumInit();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Close();
    }


    [Test, Order(1)]
    public void ValidLogin()
    {
        Thread.Sleep(3000);
        Signin signin = new Signin();
        signin.login(driver, "Admin", "admin123");
        Thread.Sleep(3000);
    }

    [Test, Order(2)]
    public void Invalid_Login()
    {
        Thread.Sleep(3000);
        Signin signin = new Signin();
        signin.login(driver, "Admin01", "1234");
        Thread.Sleep(3000);
    }

    [Test, Order(3)]
    public void Fpass()
    {
        Thread.Sleep(3000);
        ForgotPassword password = new ForgotPassword();
        password.F_Password(driver, "Admin");
        Thread.Sleep(3000);

    }

    [Test, Order(4)]
    public void InfInvalidForgotPassword()
    {
        Thread.Sleep(3000);
        ForgotPassword password = new ForgotPassword();
        password.F_Password(driver, "Admin000002");
        Thread.Sleep(3000);
    }

    [Test, Order(5)]
    public void Admin()
    {
        Signin signin = new Signin();
        signin.login(driver, "Admin", "admin123");
        Thread.Sleep(3000);
        ClickAdmin admin = new ClickAdmin();
        admin.AdminAccess(driver);
        Thread.Sleep(3000);
    }

    [Test, Order(6)]
    public void addinguser()
    {
        Signin signin = new Signin();
        signin.login(driver, "Admin", "admin123");
        Thread.Sleep(3000);
        ClickAdmin admin = new ClickAdmin();
        admin.AdminAccess(driver);
        Thread.Sleep(3000);
        AddUser user = new AddUser();
        user.Add_usr(driver);
        Thread.Sleep(3000);
    }

    [Test, Order(7)]
    public void del()
    {
        Signin signin = new Signin();
        signin.login(driver, "Admin", "admin123");
        Thread.Sleep(3000);
        ClickAdmin admin = new ClickAdmin();
        admin.AdminAccess(driver);
        Thread.Sleep(3000);
        DeleteUser delete = new DeleteUser();
        delete.del_usr(driver);
        Thread.Sleep(3000);
    }

    [Test, Order(8)]
    public void Sout()
    {
        Signin signin = new Signin();
        signin.login(driver, "Admin", "admin123");
        Thread.Sleep(3000);
        Signout signout = new Signout();
        signout.lout(driver);
    }
}
