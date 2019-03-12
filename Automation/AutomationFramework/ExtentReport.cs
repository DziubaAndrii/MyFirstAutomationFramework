using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace AutomationFramework
{
    public class ExtentReport
    {
        private static readonly Lazy<ExtentReports> _lazy = new Lazy<ExtentReports>(() => new ExtentReports());

        public static ExtentReports Instance { get { return _lazy.Value; } }


        public static void GenerateReport()
        {
                // initialize the HtmlReporter
                var htmlReporter = new ExtentHtmlReporter(($"C:\\Automation projects\\MyFirstAutomationFramework\\Automation\\Tests\\Report\\ExtentScreenshot.html"));

                // attach only HtmlReporter
                Instance.AttachReporter(htmlReporter);

                var name = TestContext.CurrentContext.Test.MethodName;
                var test = Instance.CreateTest(name);
                var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
                var errorMessage = TestContext.CurrentContext.Result.Message;
                CaptureScreenShot($"{name}.png");
                if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                {
                    test.Log(Status.Fail, "Snapshot below: " + test.AddScreenCaptureFromPath($"{name}.png"));
                    test.Log(Status.Fail, stackTrace + errorMessage);
                }
                Instance.Flush();
        }

        private static void CaptureScreenShot(string screenShotName)
        {
            var ss = DriverImplementation.Driver.TakeScreenshot();
            var captureLocation = $"C:\\Automation projects\\MyFirstAutomationFramework\\Automation\\Tests\\Report\\{screenShotName}";
            ss.SaveAsFile(captureLocation, ScreenshotImageFormat.Png);
        }
    }
}
