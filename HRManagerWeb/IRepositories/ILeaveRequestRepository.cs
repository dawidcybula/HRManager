using HRManagerWeb.Contracts;
using HRManagerWeb.Data;
using HRManagerWeb.Models;

namespace HRManagerWeb.IRepositories
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveCreateRequestVM request);

        Task<EmployeeLeaveRequestVM> GetLeaveRequestDetails();

        Task<List<LeaveRequest>> GetAllAsync(string empid);
    }
}
