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
        }
    }
}
