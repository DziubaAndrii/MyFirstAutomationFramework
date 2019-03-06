namespace AutomationFramework.Components.Models
{
   public  class CompanyModel
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
       public string Title { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string JobTitle { get; set; }
       public string DirectTel { get; set; }
       public string Email { get; set; }


       public static CompanyModel GenerateCompany()
       {
           var companyModel = new CompanyModel();
           companyModel.Name = Helpers.Helpers.CreateRandomString("AutoCompany");
           companyModel.Street = Helpers.Helpers.CreateRandomString("AutoStreet");
           companyModel.Region = Helpers.Helpers.CreateRandomString("AutoRegion");
           companyModel.City = Helpers.Helpers.CreateRandomString("AutoCity");
           companyModel.PostalCode = Helpers.Helpers.CreateRandomString("Code");
           companyModel.Country = "Ukraine";
           companyModel.WebAddress = "www.dmdjdjd.com";
           companyModel.Phone = Helpers.Helpers.CreateRandomPhone();
           companyModel.Addtag = Helpers.Helpers.CreateRandomString("AutoAddtag");
           companyModel.Title = "Dr.";
           companyModel.FirstName = Helpers.Helpers.CreateRandomString("AutoFirstNamedtag");
           companyModel.LastName = Helpers.Helpers.CreateRandomString("AutoLastName");
           companyModel.JobTitle = "COO";
           companyModel.DirectTel = Helpers.Helpers.CreateRandomPhone();
           companyModel.Email = "asd@mail.com";
            return companyModel;


       }


   }
}
