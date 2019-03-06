using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace AutomationFramework.Components.Pages
{
    public class BasePage
    {
        protected IWebDriver webDriver;
        

        protected BasePage()
        {
            this.webDriver = DriverImplementation.driver;
            PageFactory.InitElements(webDriver, (object)this);
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
    }
}
