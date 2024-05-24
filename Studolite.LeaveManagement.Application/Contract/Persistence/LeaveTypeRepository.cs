using Studolite.LeaveManagement.Domain;

namespace Studolite.LeaveManagement.Application.Contract.Persistence
{
    public class LeaveTypeRepository : IGenericRespository<LeaveType>
    {
        public Task<LeaveType> CreateAsync(LeaveType entity)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveType> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LeaveType> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LeaveType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveType> UpdateAsync(LeaveType entity)
        {
            throw new NotImplementedException();
        }
    }

}
