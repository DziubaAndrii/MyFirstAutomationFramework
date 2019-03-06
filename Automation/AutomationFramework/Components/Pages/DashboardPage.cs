using System.Collections.Generic;
using AutomationFramework.Components.Panels;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Components.Pages
{
    public class DashboardPage : BasePage
    {
        public HeaderPanel HeaderPanel => new HeaderPanel();


        [FindsBy(How = How.Id, Using = "HomePage_WelcomeMessage2")]
        private IWebElement welcomeMessage;

        public void IsWelcomeMessagePresent()
        {
            WaitForElementIsVisible(20, By.Id("HomePage_WelcomeMessage"));
        }

        public string GetWelcomeMessage()
        {
            return welcomeMessage.Text;
        }
    }
}
