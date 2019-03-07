using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework
{
    [TestFixture]
    public class DriverImplementation
    {
        public static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        public static IWebDriver Driver => driver.Value;


        [SetUp]
        public static void SetUp()
        {
            InitBrowser();
            OpenHomePage();
        }

        public static void InitBrowser()
        {
            //Add other browser drivers
            driver.Value = new ChromeDriver(@"D:\project\Automation\Drivers");
            Driver.Manage().Window.Maximize();
            //driver = new FirefoxDriver(@"D:\project\Automation\Drivers");
            //driver.Manage().Window.Maximize();
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void OpenHomePage()
        {
            Driver.Navigate().GoToUrl("https://fxdb2webauto.monexdev.net/Account/Login.aspx");
        }

        [TearDown]
        public static void CloseBrowser()
        {
            ExtentReport.GenerateReport();
            Driver.Close();
        }
    }
}
