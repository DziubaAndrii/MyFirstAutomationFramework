using System;
using AutomationFramework;
using Framework;
using Framework.Components.Pages;
using NUnit.Framework;

namespace Tests
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture("Firefox")]
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
            var userName = "Fake user name";
            var password = "Fake user password";
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
            var userName = "auto.admin";
            var password = "welcome1234";

            loginPage.SetUserName(userName);
            loginPage.SetPassword(password);
            loginPage.ClickLogin();
            var actualErrorMessage = loginPage.GetErrorMessageText();
            Assert.AreEqual(actualErrorMessage, "lox", "Error message is not same that expected");
        }

    }
}
