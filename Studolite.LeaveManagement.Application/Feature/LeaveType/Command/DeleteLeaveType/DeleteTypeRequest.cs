using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studolite.LeaveManagement.Application.Feature.LeaveType.Command.DeleteLeaveType
{
   public record DeleteTypeRequest(int Id):IRequest<Unit>;
}
