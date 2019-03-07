using System.Collections.Generic;
using AutomationFramework.Components.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Framework.Components.Pages
{
    public class AddNewLead : BasePage
    {
        [FindsBy(How = How.Id, Using = "CompanyNameLite")]
        private IWebElement Name;

        [FindsBy(How = How.Id, Using = "Address_AddressLine1")]
        private IWebElement Street;

        [FindsBy(How = How.Id, Using = "Address_State")]
        private IWebElement Region;

        [FindsBy(How = How.Id, Using = "Address_City")]
        private IWebElement City;

        [FindsBy(How = How.Id, Using = "Address_PostalCode")]
        private IWebElement PostalCode;

        [FindsBy(How = How.XPath, Using = "//span[@aria-owns = 'countriesList_listbox']")]
        private IWebElement Country;

        [FindsBy(How = How.XPath, Using = "//ul[@id='countriesList_listbox']/li")]
        private IList<IWebElement> Countrydropdown;

        [FindsBy(How = How.Id, Using = "Web")] private IWebElement WebAddress;

        [FindsBy(How = How.Id, Using = "Phone")]
        private IWebElement Phone;

        [FindsBy(How = How.XPath, Using = "//input[@class = 'tags-searchbox-input']")]
        private IWebElement Addtag;

        [FindsBy(How = How.XPath, Using = "//span[@class = 'k-select']")]
        private IWebElement Title;

        [FindsBy(How = How.XPath, Using = "//ul[@id = 'nameTitlesList_listbox']/li")]
        private IList<IWebElement> Titledropdown;

        [FindsBy(How = How.Id, Using = "FirstName")]
        private IWebElement FirstName;

        [FindsBy(How = How.Id, Using = "LastName")]
        private IWebElement LastName;

        [FindsBy(How = How.XPath, Using = "//span[@aria-owns = 'jobTitlesList_listbox']")]
        private IWebElement JobTitle;

        [FindsBy(How = How.XPath, Using = "//ul[@id= 'jobTitlesList_listbox']/li")]
        private IList<IWebElement> JobTitledropdown;

        [FindsBy(How = How.Id, Using = "TelephoneWork")]
        private IWebElement DirectTel;

        [FindsBy(How = How.Id, Using = "Mobile")]
        private IWebElement MobileTel;

        [FindsBy(How = How.Id, Using = "EmailWork")]
        private IWebElement Email;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'col-lg-3']/input")]
        private IWebElement MR;

        [FindsBy(How = How.XPath, Using = "//button [contains( ., 'Save Contact') ]")]
        private IWebElement SaveContact;

        [FindsBy(How = How.XPath, Using = "//button [contains( ., 'Save & GoTo') ]")]
        private IWebElement SaveGoTo;

        [FindsBy(How = How.XPath, Using = "//button [contains( ., 'Save & Add Another') ]")]
        private IWebElement SaveAndAnother;

        public void SetName(string text)
        {
            Name.SendKeys(text);
        }

        public void IsNameVisible()
        {
            WaitForElementIsVisible(20, By.Id("CompanyNameLite"));
        }

        public void SetStreet(string text)
        {
            Street.SendKeys(text);
        }

        public void SetRegion(string text)
        {
            Region.SendKeys(text);
        }

        public void SetCity(string text)
        {
            City.SendKeys(text);
        }

        public void SetPostalCode(string postalCode)
        {
            PostalCode.SendKeys(postalCode);
        }

        public void SelectCountry(string country)
        {
            Country.Click();
            foreach (var element in Countrydropdown)
            {
                if (country.Equals(element.Text))
                {
                    element.Click();
                    break;
                }
            }

        }

        public void SetWebAddress(string text)
        {
            WebAddress.SendKeys(text);
        }

        public void SetPhone(string text)
        {
            Phone.SendKeys(text);
        }

        public void SetAddtag(string text)
        {
            Addtag.SendKeys(text);
        }

        public void SelectTitle(string title)
        {
            Title.Click();
            foreach (var element in Titledropdown)
            {
                if (title.Equals(element.Text))
                {
                    element.Click();
                }
            }
        }

        public void SetFirstName(string text)
        {
            FirstName.SendKeys(text);
        }

        public void SetLastName(string text)
        {
            LastName.SendKeys(text);
        }

        public void SelectJobTitle(string jobtitle)
        {
            JobTitle.Click();
            foreach (var element in JobTitledropdown)
            {
                if (jobtitle.Equals(element.Text))
                {
                    element.Click();
                }
            }
        }

        public void SetDirectTel(string text)
        {
            DirectTel.SendKeys(text);
        }

        public void SetMobileTel(string text)
        {
            MobileTel.SendKeys(text);

        }

        public void SetEmail(string text)
        {
            Email.SendKeys(text);
        }

        public void ClickMR()
        {
            MR.Click();
        }

        public void ClickSaveContact()
        {
            SaveContact.Click();
        }

        public void ClickSaveGoTo()
        {
            SaveGoTo.Click();
            WaitForElementIsInvisible(15, By.XPath( "//button [contains( ., 'Save & GoTo') ]"));
        }
    }
}
