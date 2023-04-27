using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace HRManagerWeb.Models
{
    public class LeaveCreateRequestVM : IValidatableObject
    {
        
        public int LeaveTypeId { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        [Required]
        public DateTime? EndDate { get; set; }
        public SelectList? LeaveTypes { get; set; }
        public string? RequestComment { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate > EndDate) 
            {
                yield return new ValidationResult("The Start Date must be before End Date", new[] { nameof(StartDate), nameof(EndDate) });
            }

           
        }
    }
}
