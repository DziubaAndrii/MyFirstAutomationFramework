using System.Collections.Generic;
using System.Threading;
using AutomationFramework.Components.Models;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Components.Pages
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

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'AddressLine1']/..//textarea[@class = 'form-control input-large']")]
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

        [FindsBy(How = How.XPath, Using = "//span[@data-name = 'NameTitle' and not(contains(@class, 'editable-open'))]/..")]
        private IWebElement Mr;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'title col-md-2']//select[@class='form-control input-sm']/option")]
        private IList<IWebElement> MrNameDropdown;

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'FirstName']")]
        private IWebElement FirstName;

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'FirstName']/..//input")]
        private IWebElement FirstNameInput;

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'LastName']")]
        private IWebElement LastName;

        [FindsBy(How = How.XPath, Using = "//span[@data-name= 'LastName']/..//input")]
        private IWebElement LastNameInput;

        [FindsBy(How = How.XPath, Using = "//span[@data-name = 'JobTitle' and not(contains(@class, 'editable-open'))]/../span")]
        private IWebElement Position;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'position-cell')]//select[@class='form-control input-sm']/option")]
        private IList<IWebElement> PositionNameDropdown;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'telephone-cell col-md-2 table-cell']//span")]
        private IWebElement TelNumber;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'telephone-cell col-md-2 table-cell']//input[@class = 'form-control input-sm']")]
        private IWebElement TelNumberInput;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'mobile-cell col-md-2 table-cell']//span")]
        private IWebElement MobileNumber;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'mobile-cell col-md-2 table-cell']//input[@class = 'form-control input-sm']")]
        private IWebElement MobileNumberInput;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'email email-cell col-md-2 table-cell subscription-neversubscribed']//span")]
        private IWebElement Email;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'email email-cell col-md-2 table-cell subscription-neversubscribed']//input[@class = 'form-control input-sm']")]
        private IWebElement EmailInput;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'notes-cell col-md-2 table-cell']//span")]
        private IWebElement Notes;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'notes-cell col-md-2 table-cell']//input[@class = 'form-control input-sm']")]
        private IWebElement NotesInput;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'btn editable-cancel']/i")]
        private IWebElement Cancel;






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

        public void EditMr(string text)
        {
            Mr.Click();
            foreach (var element in MrNameDropdown)
            {
                if (element.Text.Contains(text))
                {
                    element.Click();
                    break;
                }
            }
           // Enter.Click();
           // WaitForElementIsVisible(2, By.XPath("//span[@data-name = 'NameTitle' and not(contains(@class, 'editable-open'))]/.."));
        }

        public void EditFirstName(string text)
        {
            FirstName.Click();
            FirstNameInput.Clear();
            FirstNameInput.SendKeys(text);
            FirstNameInput.Submit();
        }

        public void EditLastName(string text)
        {
            LastName.Click();
            LastNameInput.Clear();
            LastNameInput.SendKeys(text);
            LastNameInput.Submit();
        }

        public void EditPosition(string text)
        {
            Position.Click();
            foreach (var element in PositionNameDropdown)
            {
                if (element.Text.Contains(text))
                {
                  element.Click();
                   break;
                }
            }
           // WaitForElementIsVisible(2, By.XPath("//span[@data-name = 'JobTitle' and not(contains(@class, 'editable-open'))]/../span"));
        }

        public void EditTelNumber(string text)
        {
            TelNumber.Click();
            TelNumberInput.Clear();
            TelNumberInput.SendKeys(text);
            TelNumberInput.Submit();
        }

        public void EditMobileNumber(string text)
        {
            MobileNumber.Click();
            MobileNumberInput.Clear();
            MobileNumberInput.SendKeys(text);
            MobileNumberInput.Submit();
        }

        public CompanyModel GetCompanyModel()
            {
                return new CompanyModel()
                {
                    Name = CompanyName.Text,
                    Street = Street.Text,
                    Region = Region.Text,
                    City = City.Text,
                    Phone = Tel.Text
                };
            }

        }
    }



