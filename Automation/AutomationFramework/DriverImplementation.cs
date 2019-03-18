using System;
using System.IO;
using System.Threading;
using System.Configuration;
using AventStack.ExtentReports.Gherkin.Model;
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
        public static string WorkingDirectory = Directory.GetCurrentDirectory();
        public static string ProjectDirectory = Directory.GetParent(WorkingDirectory).Parent.FullName;

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
                driver.Value = new ChromeDriver(ProjectDirectory);
            }
            else if (BrowserName.Equals("Firefox"))
            {
                driver.Value = new FirefoxDriver(ProjectDirectory);
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
