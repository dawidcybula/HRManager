using HRManagerWeb.Data;
using HRManagerWeb.IRepositories;

namespace HRManagerWeb.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext dbconext) : base(dbconext)
        {

        }
    }
}
