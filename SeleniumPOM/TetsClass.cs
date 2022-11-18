using NUnit.Framework;
using SeleniumPOM_SauceDemo.Driver;
using SeleniumPOM_SauceDemo.Page;

namespace SeleniumPOM_Saucedemo;

public class TestClass
{
    private LoginPage _loginPage;
    private HomePage _homePage;

    [SetUp]
    public void BeforeScenario()
    {
        WebDriver.Initialize();
        _loginPage = new LoginPage();
        _homePage = new HomePage();
    }

    [TearDown]
    public void AfterScenario()
    {
        WebDriver.CleanUp();
    }


    [Test]

    public void TC01_FillUsernameAndPasswordWithValidData_ShouldInventoryPageDisplayed()
    {
        Login("standard_user", "secret_sauce");
        
    }

    [Test]
    public void TC02_ClickOnBackpack_BackpackDetailShouldBeDisplayed()
    {
        Login("standard_user", "secret_sauce");
        _homePage.Backpack.Click();
    }


    [Test]
    public void TC03_ClickButtonAddToCart_ProductShouldBeAdd()
    {
        Login("standard_user", "secret_sauce");
        _homePage.Backpack.Click();
        _homePage.AddToCardButon.Click();
    }

    [Test]
    public void TC04_ClickOnBackButton_InventoryPageShouldBeDisplayed()
    {
        Login("standard_user", "secret_sauce");
        _homePage.Backpack.Click();
        _homePage.AddToCardButon.Click();
        _homePage.BackButton.Click();
    }


    public void Login(string name, string password)
    {
        _loginPage.LoginOnPage(name, password);
    }
}
