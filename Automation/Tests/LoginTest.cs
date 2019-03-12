using System;
using AutomationFramework;
using Framework;
using Framework.Components.Pages;
using NUnit.Framework;
using System.Configuration;
using System.Collections.Specialized;
using Framework.Components.Helpers;
using Tests.UserCredentials;

namespace Tests
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture("Chrome")]
    public class LoginTest : DriverImplementation
    {
        [ThreadStatic]private static LoginPage loginPage;
        
        public LoginTest(string browser) : base(browser)
        {
        }

        [SetUp]
        public void SetUp()
        {
            loginPage = new LoginPage();

        }
        

        [Test]
        public void IncorrectLogin()
        {
            var userName = RandomHelper.CreateRandomAlphaNumeric(8);
            var password = RandomHelper.CreateRandomAlphaNumeric(8);
            var expectedErrorMessage = "Incorrect username/password";

            loginPage.SetUserName(userName);
            loginPage.SetPassword(password);
            loginPage.ClickLogin();
            var actualErrorMessage = loginPage.GetErrorMessageText();
            Assert.AreEqual(actualErrorMessage, expectedErrorMessage, "Error message is not same that expected");
            
        }

        [Test]
        public void CorrectLogin()
        {
            loginPage.SetUserName(Credentials.adminUserName);
            loginPage.SetPassword(Credentials.adminPassword);
            loginPage.ClickLogin();
            var actualErrorMessage = loginPage.GetErrorMessageText();
            Assert.AreEqual(actualErrorMessage, "lox", "Error message is not same that expected");
        }

    }
}
