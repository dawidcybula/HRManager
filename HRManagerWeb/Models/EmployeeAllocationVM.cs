using HRManagerWeb.Data;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HRManagerWeb.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
      
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }

    }
}
