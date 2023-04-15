using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HRManagerWeb.Data
{
    public class Employee : IdentityUser
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Taxid { get; set; }   
        public DateTime DateofBirth { get; set; }
        public DateTime JoinDate { get; set; }


    }
}
