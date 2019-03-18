using AutomationFramework.Components.Enums;
using AutomationFramework.Components.Helpers;

namespace AutomationFramework.Components.Models
using Framework.Components.Helpers;

namespace Framework.Components.Models
{
   public class CompanyModel
   {
       public string Name { get; set; }
       public string Street { get; set; }
       public string Region { get; set; }
       public string City { get; set; }
       public string PostalCode { get; set; }
       public string Country { get; set; }
       public string WebAddress { get; set; }
       public string Phone { get; set; }
       public string Addtag { get; set; }



       public static CompanyModel GenerateCompany()
       {
           var companyModel = new CompanyModel();
           companyModel.Name = Helpers.RandomHelper.CreateRandomString("AutoCompany");
           companyModel.Street = Helpers.RandomHelper.CreateRandomString("AutoStreet");
           companyModel.Region = Helpers.RandomHelper.CreateRandomString("AutoRegion");
           companyModel.City = Helpers.RandomHelper.CreateRandomString("AutoCity");
           companyModel.PostalCode = Helpers.RandomHelper.CreateRandomString("Code");
           companyModel.Country = "Ukraine";
           companyModel.WebAddress = $"www.{RandomHelper.CreateRandomAlphabetic(10)}.com";
           companyModel.Phone = Helpers.RandomHelper.CreateRandomPhone();
           companyModel.Addtag = Helpers.RandomHelper.CreateRandomString("AutoAddtag");
           companyModel.Title = "Dr.";
           companyModel.FirstName = Helpers.RandomHelper.CreateRandomString("AutoFirstNamedtag");
           companyModel.LastName = Helpers.RandomHelper.CreateRandomString("AutoLastName");
           companyModel.JobTitle = "COO";
           companyModel.DirectTel = Helpers.RandomHelper.CreateRandomPhone();
           companyModel.Email = $"{RandomHelper.CreateRandomAlphaNumeric(8)}@mail.com";
            return companyModel;

           return companyModel;


       }


   }
}
