using Studolite.LeaveManagement.Domain;

namespace Studolite.LeaveManagement.Application.Contract.Persistence
{
    public class LeaveAllocationRepository : IGenericRespository<LeaveAllocation>
    {
        Task<LeaveAllocation> IGenericRespository<LeaveAllocation>.CreateAsync(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        Task<LeaveAllocation> IGenericRespository<LeaveAllocation>.DeleteAsync()
        {
            throw new NotImplementedException();
        }

        Task<LeaveAllocation> IGenericRespository<LeaveAllocation>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<LeaveAllocation> IGenericRespository<LeaveAllocation>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<LeaveAllocation> IGenericRespository<LeaveAllocation>.UpdateAsync(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }
    }

}
