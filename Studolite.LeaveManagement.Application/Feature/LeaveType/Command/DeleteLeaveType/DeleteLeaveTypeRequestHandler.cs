using MediatR;
using Studolite.LeaveManagement.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studolite.LeaveManagement.Application.Exceptions;
namespace Studolite.LeaveManagement.Application.Feature.LeaveType.Command.DeleteLeaveType
{
    public class DeleteLeaveTypeRequestHandler : IRequestHandler<DeleteTypeRequest, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public DeleteLeaveTypeRequestHandler(ILeaveTypeRepository leaveTypeRepository)
        {
            this._leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<Unit> Handle(DeleteTypeRequest request, CancellationToken cancellationToken)
        {
            var leaveType=await  _leaveTypeRepository.GetByIdAsync(request.Id);
            if (leaveType == null)
            {
                throw new NotFoundException(nameof(Domain.LeaveType), request.Id);
            }
            await _leaveTypeRepository.DeleteAsync(leaveType.Id);

            return Unit.Value;
        }
    }
}
