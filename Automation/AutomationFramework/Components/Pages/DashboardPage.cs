using System;
using AutomationFramework.Components.Pages;
using Framework.Components.Panels;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Framework.Components.Pages
{
    public class DashboardPage : BasePage
    {
        public HeaderPanel HeaderPanel => new HeaderPanel();


        [FindsBy(How = How.Id, Using = "HomePage_WelcomeMessage")]
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
