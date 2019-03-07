using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationFramework
{
    [TestFixture]
    public class DriverImplementation
    {
        public static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        public static IWebDriver Driver => driver.Value;
        public string BrowserName;

        public DriverImplementation(string browser)
        {
            this.BrowserName = browser;
        }

        [SetUp]
        public void SetUp()
        {
            InitBrowser();
            OpenHomePage();
        }

        public void InitBrowser()
        {
            if (BrowserName.Equals("Chrome"))
            {
                driver.Value = new ChromeDriver(@"D:\MainProjects\MyFirstAutomationFramework\Automation\Drivers");
            }
            else if (BrowserName.Equals("Firefox"))
            {
                driver.Value = new FirefoxDriver(@"D:\MainProjects\MyFirstAutomationFramework\Automation\Drivers");
            }
            Driver.Manage().Window.Maximize();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void OpenHomePage()
        {
            Driver.Navigate().GoToUrl("https://fxdb2webauto.monexdev.net/Account/Login.aspx");
        }

        [TearDown]
        public void CloseBrowser()
        {
            ExtentReport.GenerateReport();
            Driver.Close();
        }
    }
}
