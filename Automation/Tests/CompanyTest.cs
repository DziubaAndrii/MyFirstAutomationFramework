using System;
using AutomationFramework;
using Framework;
using Framework.Components.Models;
using Framework.Components.Pages;
using Framework.Components.Panels;
using NUnit.Framework;

namespace Tests
{
    [Parallelizable(ParallelScope.All)]
    public class CompanyTest : DriverImplementation
    {
        [ThreadStatic] private static LoginPage loginPage;
        [ThreadStatic] private static AddNewLead _addNewLead;
        [ThreadStatic] private static HeaderPanel headerPanel;
        [ThreadStatic] private static DashboardPage _dashboardPage;
        [ThreadStatic] private static CompanyPage companyPage;

        [SetUp]
        public void SetUp()
        {
            loginPage = new LoginPage();
            _addNewLead = new AddNewLead();//mistake AddNewLead
            _dashboardPage = new DashboardPage();
            companyPage = new CompanyPage();
            headerPanel = new HeaderPanel();
        }

        [Test]
        public void CreateCompanyTest()
        {
            var model = CompanyModel.GenerateCompany();
            Login();
            headerPanel.clickaddNewLead();
            SetCompanyDetails(model);
            SetCompanyContact(model);
            _addNewLead.ClickSaveGoTo();
            var actualCompanyName = companyPage.GetName();
            Assert.AreEqual(actualCompanyName, model.Name, "Company name is not same that expected");
        }

        [Test]
        public void EditCompanyTest()
        {
            var model = CompanyModel.GenerateCompany();
            Login();
/*            headerPanel.clickaddNewLead();
            SetCompanyDetails(model);
            SetCompanyContact(model);
            _addNewLead.ClickSaveGoTo();
            var actualCompanyName = companyPage.GetName();
            Assert.AreEqual(actualCompanyName, model.Name, "Company name is not same that expected");
            model = CompanyModel.GenerateCompany();
            SetCompanyInfo(model);
            var model2 = companyPage.GetCompanyModel();
            Assert.AreEqual(model.DirectTel, model2.DirectTel, "Tel is not same that expected");
            Assert.AreEqual(model.City, model2.City, "City is not same that expected");
            Assert.AreEqual(model.Name, model2.Name, "Name is not same that expected");
            Assert.AreEqual(model.Street, model2.Street, "Street is not same that expected");
            Assert.AreEqual(model.Region, model2.Region, "Region is not same that expected");*/
        }


        private void Login()
        {
            var userName = "auto.admin";
            var password = "welcome1234";

            loginPage.SetUserName(userName);
            loginPage.SetPassword(password);
            loginPage.ClickLogin();
            _dashboardPage.IsWelcomeMessagePresent();
        }

        private void SetCompanyDetails(CompanyModel model)
        {
            _addNewLead.IsNameVisible();
            _addNewLead.SetName(model.Name);
            _addNewLead.SetStreet(model.Street);
            _addNewLead.SetRegion(model.Region);
            _addNewLead.SetCity(model.City);
            _addNewLead.SetPostalCode(model.PostalCode);
            _addNewLead.SelectCountry(model.Country);
            _addNewLead.SetWebAddress(model.WebAddress);
            _addNewLead.SetPhone(model.Phone);
            _addNewLead.SetAddtag(model.Addtag);
        }

        private void SetCompanyContact(CompanyModel model)
        {
            _addNewLead.SelectTitle(model.Title);
            _addNewLead.SetFirstName(model.FirstName);
            _addNewLead.SetLastName(model.LastName);
            _addNewLead.SelectJobTitle(model.JobTitle);
            _addNewLead.SetDirectTel(model.DirectTel);
            _addNewLead.SetMobileTel(model.DirectTel);
            _addNewLead.SetEmail(model.Email);
            _addNewLead.ClickMR();
            _addNewLead.ClickSaveContact();
        }

        private void SetCompanyInfo(CompanyModel model)
        {
            companyPage.EditName(model.Name);
            companyPage.EditTradingName(model.Name);
            companyPage.EditStreet(model.Street);
            companyPage.EditRegion(model.Region);
            companyPage.EditCity(model.City);
            companyPage.EditTel(model.DirectTel);
            //companyPage.EditMr("Sir");
            companyPage.EditFirstName(model.Name);
        }
    }
}
