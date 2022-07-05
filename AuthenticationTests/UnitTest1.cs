using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AuthenticationTests
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By _loginInputButton = By.XPath("//input[@name='USER_LOGIN']");
        private readonly By _passwordInputButton = By.XPath("//input[@name='USER_PASSWORD']");
        private readonly By _loginButton = By.XPath("//input[@name='Login']");
        private const string _login = "test@gmail.com";
        private const string _password = "testpass";

        [SetUp]
        public void Setup()
        {   
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://texdesign.ru/auth/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var login = driver.FindElement(_loginInputButton);
            login.SendKeys(_login);

            var password = driver.FindElement(_passwordInputButton);
            password.SendKeys(_password);

            var continueLogin = driver.FindElement(_loginButton);
            continueLogin.Click();
        }   
    }
}