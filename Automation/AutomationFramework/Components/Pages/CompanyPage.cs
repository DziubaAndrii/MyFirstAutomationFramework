using System.Collections.Generic;
using AutomationFramework.Components.Pages;
using Framework.Components.Models;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Framework.Components.Pages
{
    public class CompanyPage : BasePage

    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'company-name']/a")]
        private IWebElement Name;

        [FindsBy(How = How.XPath, Using = "//span[@data-name = 'CompanyName']")]
        private IWebElement CompanyName;

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'CompanyName']/..//input")]
        private IWebElement CompanyNameInput;

        [FindsBy(How = How.XPath, Using = "//span[@data-name = 'TradingName']")]
        private IWebElement TradingNameUser;

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'TradingName']/..//input")]
        private IWebElement TradingNameUserInput;

        [FindsBy(How = How.XPath, Using = "//span[@data-name = 'AddressLine1']")]
        private IWebElement Street;

        [FindsBy(How = How.XPath,
            Using = "//span[@data-name= 'AddressLine1']/..//textarea[@class = 'form-control input-large']")]
        private IWebElement StreetInput;

        [FindsBy(How = How.XPath, Using = "//span[@data-name = 'State']")]
        private IWebElement Region;

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'State']/..//input")]
        private IWebElement RegionInput;

        [FindsBy(How = How.XPath, Using = "//span[@data-name = 'City']")]
        private IWebElement City;

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'City']/..//input")]
        private IWebElement CityInput;

        [FindsBy(How = How.XPath, Using = "//span[@data-name = 'TelephoneNumber']")]
        private IWebElement Tel;

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'TelephoneNumber']/..//input")]
        private IWebElement TelInput;

        [FindsBy(How = How.XPath, Using = "//select[@class= 'form-control input-sm']")]
        private IWebElement Mr;

        [FindsBy(How = How.XPath, Using = "//div[@class='editable-input']/select[@class='form-control input-sm']/option")]
        private IList<IWebElement> Mrdropdown;

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'FirstName']")]
        private IWebElement FirstName;

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'FirstName']/..//input")]
        private IWebElement FirstNameInput;

        





        public string GetName()
        {
            WaitForElementIsVisible(10, By.XPath("//div[@class = 'company-name']/a"));
            return Name.Text;
        }

        public void EditName(string text)
        {
            CompanyName.Click();
            CompanyNameInput.Clear();
            CompanyNameInput.SendKeys(text);
            CompanyNameInput.Submit();
            WaitForSpinner();
        }

        public void EditTradingName(string text)
        {
            TradingNameUser.Click();
            TradingNameUserInput.Clear();
            TradingNameUserInput.SendKeys(text);
            TradingNameUserInput.Submit();
            WaitForSpinner();

        }

        public void EditStreet(string text)
        {
            WaitForElementIsVisible(10, By.XPath("//span[@data-name = 'AddressLine1']"));
            Street.Click();
            StreetInput.Clear();
            StreetInput.SendKeys(text);
            StreetInput.Submit();
            WaitForSpinner();
        }

        public void EditRegion(string text)
        {
            Region.Click();
            RegionInput.Clear();
            RegionInput.SendKeys(text);
            RegionInput.Submit();
            WaitForSpinner();
        }

        public void EditCity(string text)
        {
            City.Click();
            CityInput.Clear();
            CityInput.SendKeys(text);
            CityInput.Submit();
            WaitForSpinner();
        }

        public void EditTel(string text)
        {
            Tel.Click();
            TelInput.Clear();
            TelInput.SendKeys(text);
            TelInput.Submit();
            WaitForSpinner();
        }

        //public void EditMr(string text)
        //{
        //    Mr.Click();

        //    foreach (var element in Mrdropdown)
        //    {
        //        if (element.Equals(text))
        //        {
        //            element.Click();
        //        }
        //    }
        //}

        public void EditFirstName(string text)
        {
            FirstName.Click();
            FirstNameInput.Clear();
            FirstNameInput.SendKeys(text);
            FirstNameInput.Submit();
        }


        public CompanyModel GetCompanyModel()
            {
                return new CompanyModel()
                {
                    Name = CompanyName.Text,
                    Street = Street.Text,
                    Region = Region.Text,
                    City = City.Text,
                    DirectTel = Tel.Text
                };
            }

        }
    }



