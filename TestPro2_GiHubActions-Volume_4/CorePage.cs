using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestPro2_GiHubActions_Volume_4
{
    public class CorePage
    {
        private static IWebDriver _driver;
        public CorePage(IWebDriver driver) { _driver = driver; }
        private IWebElement _usernametxt => _driver.FindElement(By.Id("username"));
        private IWebElement _passwordtxt => _driver.FindElement(By.Id("password"));
        private IWebElement _loginbtn => _driver.FindElement(By.Id("login"));
        public void LoginPage(string Username, string Password)
        {
            _usernametxt.SendKeys(Username);
            _passwordtxt.SendKeys(Password);
            _loginbtn.Click();
        }
    }
}
