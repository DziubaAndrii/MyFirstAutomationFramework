using Framework.Components.Helpers;

namespace AutomationFramework.Components.Models
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
           companyModel.Name = RandomHelper.CreateRandomString("AutoCompany");
           companyModel.Street = RandomHelper.CreateRandomString("AutoStreet");
           companyModel.Region = RandomHelper.CreateRandomString("AutoRegion");
           companyModel.City = RandomHelper.CreateRandomString("AutoCity");
           companyModel.PostalCode = RandomHelper.CreateRandomString("Code");
           companyModel.Country = "Ukraine";
           companyModel.WebAddress = $"www.{RandomHelper.CreateRandomAlphabetic(10)}.com";
           companyModel.Phone = RandomHelper.CreateRandomPhone();
           companyModel.Addtag = RandomHelper.CreateRandomString("AutoAddtag");
            return companyModel;
       }


   }
}
