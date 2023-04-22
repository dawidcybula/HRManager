using System.ComponentModel.DataAnnotations;

namespace HRManagerWeb.Data
{
    public class LeaveType : BaseEntity
    {
       
        public string Name { get; set; }

        [Range(1, 120)]
        public int DefaultDays { get; set; }
      
    }
}
