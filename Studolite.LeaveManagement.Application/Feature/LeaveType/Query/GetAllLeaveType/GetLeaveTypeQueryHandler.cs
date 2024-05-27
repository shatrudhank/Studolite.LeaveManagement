using AutoMapper;
using MediatR;
using Studolite.LeaveManagement.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studolite.LeaveManagement.Application.Feature.LeaveType.Query.GetAllLeaveType
{
    public class GetLeaveTypeQueryHandler : IRequestHandler<GetLeaveTypeQuery, IList<LeaveTypeDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public GetLeaveTypeQueryHandler(IMapper mapper,ILeaveTypeRepository leaveTypeRepository)
        {
            this._mapper = mapper;
            this._leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<IList<LeaveTypeDTO>> Handle(GetLeaveTypeQuery request, CancellationToken cancellationToken)
        {
            //Query database
            var leaveType = await _leaveTypeRepository.GetAsync();

            var data= _mapper.Map<IList<LeaveTypeDTO>>(leaveType);

            return data;
        }
    }
}
