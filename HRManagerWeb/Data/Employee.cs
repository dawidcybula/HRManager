using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HRManagerWeb.Data
{
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Taxid { get; set; }   
        public DateTime DateofBirth { get; set; }
        public DateTime JoinDate { get; set; }


    }
}
