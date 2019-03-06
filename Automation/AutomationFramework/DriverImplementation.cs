using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationFramework
{
    [TestFixture]
    public class DriverImplementation
    {
        public static IWebDriver driver;
        


        [SetUp]
        public static void SetUp()
        {
            InitBrowser();
            OpenHomePage();
        }

        public static void InitBrowser()
        {
            //Add other browser drivers
            driver = new ChromeDriver(@"D:\project\Automation\Drivers");
            driver.Manage().Window.Maximize();
            //driver = new FirefoxDriver(@"D:\project\Automation\Drivers");
            //driver.Manage().Window.Maximize();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://fxdb2webauto.monexdev.net/Account/Login.aspx");
        }

        [OneTimeTearDown]
        public static void CloseBrowser()
        {
            driver.Close();
        }
    }
}
