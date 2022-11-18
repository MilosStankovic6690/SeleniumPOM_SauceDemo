using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = SeleniumPOM_SauceDemo.Driver.WebDriver;

namespace SeleniumPOM_SauceDemo.Page;

public class HomePage
{
    private IWebDriver driver = WebDriver.Instance;

    public IWebElement Backpack => driver.FindElement(By.CssSelector(".inventory_item_img a"));
    public IWebElement AddToCardButon => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
    public IWebElement BackButton => driver.FindElement(By.Id("back-to-products"));

   

    

}
