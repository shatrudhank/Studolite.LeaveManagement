using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studolite.LeaveManagement.Application.Feature.LeaveType.Query.GetLeaveTypeDetails
{
    public record GetLeaveTypeDetailsQuery(int id):IRequest<LeaveTypeDetailDTO>;
  
}
