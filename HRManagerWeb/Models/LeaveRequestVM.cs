using HRManagerWeb.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRManagerWeb.Models
{
    public class LeaveRequestVM : LeaveCreateRequestVM
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public LeaveTypeVM LeaveTypeVM { get; set; }
        public DateTime DateRequested { get; set; }
        public string? RequestComment { get; set; }

        public bool? Approved { get; set; }
        public bool Canceled { get; set; }

        
    }
}
