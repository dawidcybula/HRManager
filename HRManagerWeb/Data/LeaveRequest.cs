using System.ComponentModel.DataAnnotations.Schema;

namespace HRManagerWeb.Data
{
    public class LeaveRequest : BaseEntity
    {
        public int Id;

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        public DateTime DateRequested { get; set; }
        public string ?RequestComment { get; set; }

        public bool? Approved { get; set; } 
        public bool Canceled { get; set; }

        public string RequestingEmployeeId { get; set; }
    }
}
