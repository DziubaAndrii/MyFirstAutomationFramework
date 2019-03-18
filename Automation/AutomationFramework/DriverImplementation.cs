using System;
using System.IO;
using System.Threading;
using System.Configuration;
using System.Reflection;
using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Html5;

namespace AutomationFramework
{
    [TestFixture]
    public class DriverImplementation
    {
        public static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        public static IWebDriver Driver => driver.Value;
        public string BrowserName;
        public static string DriversDirectory = Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).Parent?.Parent?.FullName + "\\Drivers";

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
                driver.Value = new ChromeDriver(DriversDirectory);
            }
            else if (BrowserName.Equals("Firefox"))
            {
                driver.Value = new FirefoxDriver(DriversDirectory);
            }
            Driver.Manage().Window.Maximize();
        }


        public static void OpenHomePage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings.Get("basicUrl"));
        }

        [TearDown]
        public void CloseBrowser()
        {
            ExtentReport.GenerateReport();
            Driver.Close();
        }
    }
}
