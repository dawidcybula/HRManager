﻿using System.ComponentModel.DataAnnotations;

namespace HRManagerWeb.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date Joined")]
        public DateTime JoinDate { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }





    }
}
