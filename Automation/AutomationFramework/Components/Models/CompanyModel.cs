﻿namespace Framework.Components.Models
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
           companyModel.Name = Helpers.RandomHelper.CreateRandomString("AutoCompany");
           companyModel.Street = Helpers.RandomHelper.CreateRandomString("AutoStreet");
           companyModel.Region = Helpers.RandomHelper.CreateRandomString("AutoRegion");
           companyModel.City = Helpers.RandomHelper.CreateRandomString("AutoCity");
           companyModel.PostalCode = Helpers.RandomHelper.CreateRandomString("Code");
           companyModel.Country = "Ukraine";
           companyModel.WebAddress = "www.dmdjdjd.com";
           companyModel.Phone = Helpers.RandomHelper.CreateRandomPhone();
           companyModel.Addtag = Helpers.RandomHelper.CreateRandomString("AutoAddtag");
           companyModel.Title = "Dr.";
           companyModel.FirstName = Helpers.RandomHelper.CreateRandomString("AutoFirstNamedtag");
           companyModel.LastName = Helpers.RandomHelper.CreateRandomString("AutoLastName");
           companyModel.JobTitle = "COO";
           companyModel.DirectTel = Helpers.RandomHelper.CreateRandomPhone();
           companyModel.Email = "asd@mail.com";
            return companyModel;


       }


   }
}
