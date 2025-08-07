using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestPro2_GiHubActions_Volume_4
{
    [TestClass]
    public class CoreTestCases
    {
        [TestMethod]
        public void TC_LoginPage()
        {
            var _options = new ChromeOptions();
            _options.AddArgument("--headless");
            _options.AddArgument("--no-sandbox");
            _options.AddArgument("--disable-gpu");
            var _driver = new ChromeDriver(_options);
            _driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
            _driver.Manage().Window.Maximize();
            CorePage _corepage = new CorePage(_driver);
            _corepage.LoginPage("nagalakshmin", "l@kshmin");
            Thread.Sleep(30000);
            _driver.Quit();
        }
    }
}
