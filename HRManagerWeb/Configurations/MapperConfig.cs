using AutoMapper;
using HRManagerWeb.Data;
using HRManagerWeb.Models;

namespace HRManagerWeb.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation,LeaveAllocationVM >().ReverseMap();
            CreateMap<LeaveRequest,LeaveCreateRequestVM >().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestVM>().ReverseMap();

        }
    }
}
