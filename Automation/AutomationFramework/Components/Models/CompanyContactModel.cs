using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Components.Enums;
using AutomationFramework.Components.Helpers;

namespace AutomationFramework.Components.Models
{
   public class CompanyContactModel
    {
        public TitleDropdown Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DirectTel { get; set; }
        public string Email { get; set; }
        public PositionDropdown Position { get; set; }

        public static CompanyContactModel GenerateContact()
        {
            var contactModel = new CompanyContactModel
            {
                Title = Utils.GetUniqueEnumValue<TitleDropdown>(),
                FirstName = Utils.CreateRandomString("AutoFirstName"),
                LastName = Utils.CreateRandomString("AutoLastName"),
                DirectTel = Utils.CreateRandomPhone(),
                Email = "asd@mail.com",
                Position = Utils.GetUniqueEnumValue<PositionDropdown>()
            };

            return contactModel;


        }
    }
}
