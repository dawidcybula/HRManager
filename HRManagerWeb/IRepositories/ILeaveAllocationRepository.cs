﻿using HRManagerWeb.Contracts;
using HRManagerWeb.Data;
using HRManagerWeb.Models;

namespace HRManagerWeb.IRepositories
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
       Task LeaveAllocation(int LeaveTypeId);
       Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);

        Task<EmployeeAllocationVM> GetEmployeeLeaveAllocation(string employeeId);
    }
}
