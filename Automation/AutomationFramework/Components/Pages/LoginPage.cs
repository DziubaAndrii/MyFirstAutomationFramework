using AutomationFramework.Components.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Framework.Components.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[@href = '/Account/ResetPassword.aspx']")]
        private IWebElement forgotPassword;

        [FindsBy(How = How.Id, Using = "SectionArticlePlaceHolder_LoginUser_UserName")]
        private IWebElement userName;

        [FindsBy(How = How.Id, Using = "SectionArticlePlaceHolder_LoginUser_Password")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "SectionArticlePlaceHolder_LoginUser_LoginButton")]
        private IWebElement login;

        [FindsBy(How = How.XPath, Using = "//span[@id='SectionArticlePlaceHolder_LtrStaffWaiting']/span")]
        private IWebElement errorMessage;

        public void SetUserName(string text)
        {
            userName.SendKeys(text);
        }

        public void SetPassword(string text)
        {
            password.SendKeys(text);
        }

        public void ClickLogin()
        {
            login.Click();
        }

        public bool IsForgotPasswordVisible()
        {
            return forgotPassword.Displayed;
        }

        public string GetErrorMessageText()
        {
            return errorMessage.Text;
        }
    }
}
