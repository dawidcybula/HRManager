using System.ComponentModel.DataAnnotations;

namespace HRManagerWeb.Models
{

    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        [Range(1, 120)]
        public int DefaultDays { get; set; }




    }
}
