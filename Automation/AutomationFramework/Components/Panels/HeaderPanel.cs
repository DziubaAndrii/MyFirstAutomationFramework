

using System;
using System.Collections.Generic;
using AutomationFramework.Components.Enums;
using AutomationFramework.Components.Pages;
using AutomationFramework.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.Components.Panels
{
    public class HeaderPanel : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'dropdown top-menu-item')]/a")]
        private IList<IWebElement> topMenu;

        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'dropdown top-menu-item')]/a")]
        private IList<IWebElement> subMenu;

        [FindsBy(How = How.XPath, Using = "//i[@class='new-lead-icon glyphicon glyphicon-new-lead']")]
        private IWebElement addNewLead;


        public void clickaddNewLead()
        {
           addNewLead.Click();
        }

        public void OpenTopMenu(TopMenu element)
        {
            foreach (var top in topMenu)
            {
                if (element.Equals(top.Text))
                {
                    top.Click();
                }
            }
        }

        //OpenSubMenu
        public void OpenSubMenu(string menu)
        {
            foreach (var sub in subMenu)
            {
                if (menu.Equals(sub.Text))
                {
                    sub.Click();
                }
            }
        }








    }
 


}
