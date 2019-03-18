using AutomationFramework.Components.Enums;
using AutomationFramework.Components.Helpers;

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
           var companyModel = new CompanyModel
           {
               Name = Utils.CreateRandomString("AutoCompany"),
               Street = Utils.CreateRandomString("AutoStreet"),
               Region = Utils.CreateRandomString("AutoRegion"),
               City = Utils.CreateRandomString("AutoCity"),
               PostalCode = Utils.CreateRandomString("Code"),
               Country = "Ukraine",
               WebAddress = "www.dmdjdjd.com",
               Phone = Utils.CreateRandomPhone(),
               Addtag = Utils.CreateRandomString("AutoAddtag"),
           };

           return companyModel;


       }


   }
}
