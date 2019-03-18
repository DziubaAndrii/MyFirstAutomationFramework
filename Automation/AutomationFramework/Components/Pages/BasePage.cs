using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace AutomationFramework.Components.Pages
{
    public class BasePage
    {
        protected IWebDriver webDriver;
        

        protected BasePage()
        {
            this.webDriver = DriverImplementation.Driver;
            PageFactory.InitElements(webDriver, this);
        }

        public void WaitForElementIsVisible(int seconds, By by)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public void WaitForElementIsInvisible(int seconds, By by)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }

        public void WaitForSpinner()
        {
            WaitForElementIsInvisible(5, By.ClassName("editableform-loading"));
        }

        public void EnterAction()
        {
            var builder = new Actions(webDriver);
            builder.SendKeys(Keys.Enter);
        }
    }
}
