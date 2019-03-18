using System;
using AutomationFramework;
using Framework.Components.Pages;
using NUnit.Framework;
using Framework.Components.Helpers;
using Tests.UserCredentials;

namespace Tests
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture("Chrome")]
    public class LoginTest : DriverImplementation
    {
        [ThreadStatic]private static LoginPage loginPage;
        [ThreadStatic] private static DashboardPage dashboardPage;

        public LoginTest(string browser) : base(browser)
        {
        }

        [SetUp]
        public void SetUp()
        {
            loginPage = new LoginPage();
            dashboardPage = new DashboardPage();

        }
        

        [Test]
        public void IncorrectCredentialsLogin()
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
        public void CorrectCredentialsLogin()
        {
            loginPage.SetUserName(Credentials.adminUserName);
            loginPage.SetPassword(Credentials.adminPassword);
            loginPage.ClickLogin();
            dashboardPage.IsWelcomeMessagePresent();
            var role = Credentials.adminUserName.Replace(".", " ");
            Assert.True(dashboardPage.GetWelcomeMessage().EndsWith(role));
            

        }

    }
}
