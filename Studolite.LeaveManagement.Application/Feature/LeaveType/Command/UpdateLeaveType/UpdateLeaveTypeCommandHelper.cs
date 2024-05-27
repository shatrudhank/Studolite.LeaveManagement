using AutoMapper;
using MediatR;
using Studolite.LeaveManagement.Application.Contract.Persistence;
using Studolite.LeaveManagement.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studolite.LeaveManagement.Application.Feature.LeaveType.Command.UpdateLeaveType
{
    public class UpdateLeaveTypeCommandHelper : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public UpdateLeaveTypeCommandHelper(IMapper mapper,ILeaveTypeRepository leaveTypeRepository)
        {
            this._mapper = mapper;
            this._leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveTypeToUpdate = _mapper.Map<Domain.LeaveType>(request);
            
            await _leaveTypeRepository.UpdateAsync(leaveTypeToUpdate);
            return Unit.Value;

        }
    }
}
