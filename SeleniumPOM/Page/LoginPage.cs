using OpenQA.Selenium;
using WebDriver = SeleniumPOM_SauceDemo.Driver.WebDriver;

namespace SeleniumPOM_SauceDemo.Page
{
    public class LoginPage
    {

        private IWebDriver driver = WebDriver.Instance;

        public IWebElement UserName => driver.FindElement(By.Name("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login-button"));

        public void LoginOnPage(string name, string password)
        {
            UserName.SendKeys(name);
            Password.SendKeys(password);
            LoginButton.Submit();
        }
    }
}
