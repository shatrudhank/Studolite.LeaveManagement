using Studolite.LeaveManagement.Domain;

namespace Studolite.LeaveManagement.Application.Contract.Persistence
{
    public class LeaveRequestRepository : IGenericRespository<LeaveRequest>
    {
        Task<LeaveRequest> IGenericRespository<LeaveRequest>.CreateAsync(LeaveRequest entity)
        {
            throw new NotImplementedException();
        }

        Task<LeaveRequest> IGenericRespository<LeaveRequest>.DeleteAsync()
        {
            throw new NotImplementedException();
        }

        Task<LeaveRequest> IGenericRespository<LeaveRequest>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<LeaveRequest> IGenericRespository<LeaveRequest>.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<LeaveRequest> IGenericRespository<LeaveRequest>.UpdateAsync(LeaveRequest entity)
        {
            throw new NotImplementedException();
        }
    }

}
