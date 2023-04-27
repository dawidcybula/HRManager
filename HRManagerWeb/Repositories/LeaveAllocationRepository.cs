using AutoMapper;
using HRManagerWeb.Constants;
using HRManagerWeb.Data;
using HRManagerWeb.IRepositories;
using HRManagerWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRManagerWeb.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _dbconext;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveAllocationRepository(ApplicationDbContext dbconext,
            UserManager<Employee> usermanager,
            ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper
            
            ) : base(dbconext)
        {
            this._dbconext = dbconext;
            this._userManager = usermanager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await _dbconext.LeaveAllocations.AnyAsync(x => x.EmployeeId == employeeId 
            && x.LeaveTypeId == leaveTypeId 
            && x.Period == period
            );
        }

        public async Task<EmployeeAllocationVM> GetEmployeeLeaveAllocation(string employeeId)
        {
            var allocations = await _dbconext.LeaveAllocations
                .Include(x => x.LeaveType)
                .Where(x => x.EmployeeId == employeeId)
                .ToListAsync();

            var employee = await _userManager.FindByIdAsync(employeeId);
           
            var employeealocationmodel = mapper.Map<EmployeeAllocationVM>(employee);
            employeealocationmodel.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);

            return employeealocationmodel;
        }

        public async Task LeaveAllocation(int LeaveTypeId)
        {
            var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(LeaveTypeId);
            var allocations = new List<LeaveAllocation>();
            foreach (var employee in employees) 
            {
                if (await AllocationExists(employee.Id, leaveType.Id, period))
                    continue;

                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = LeaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                    
                });
                
            }
            await AddRangeAsync(allocations);
          
        }
    }
}
