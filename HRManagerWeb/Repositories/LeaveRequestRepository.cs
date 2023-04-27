using AutoMapper;
using HRManagerWeb.Data;
using HRManagerWeb.IRepositories;
using HRManagerWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HRManagerWeb.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext dbconext;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly UserManager<Employee> userManager;

        public LeaveRequestRepository(ApplicationDbContext dbconext,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor,
            ILeaveAllocationRepository leaveAllocationRepository,
            UserManager<Employee> userManager
            ) : base(dbconext)
        {
            this.dbconext = dbconext;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.userManager = userManager;
        }

        public async Task<bool> CreateLeaveRequest(LeaveCreateRequestVM request)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext?.User);
            var leaveRequest = mapper.Map<LeaveRequest>(request);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync( leaveRequest );

            return true;
        }

        public async Task<List<LeaveRequest>> GetAllAsync(string empid)
        {
            return await dbconext.LeaveRequests.Where(q => q.RequestingEmployeeId == empid).ToListAsync();
        }

        public async Task<EmployeeLeaveRequestVM> GetLeaveRequestDetails()
        {

                var user = await userManager.GetUserAsync(httpContextAccessor?.HttpContext?.User);
                var allocations = (await leaveAllocationRepository.GetEmployeeLeaveAllocation(user.Id)).LeaveAllocations;
            var requests = mapper.Map<List<LeaveRequestVM>>(await GetAllAsync(user.Id));

                var model = new EmployeeLeaveRequestVM(allocations, requests);

                return model;
            
        }
    }
}
