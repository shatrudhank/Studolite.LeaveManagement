
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studolite.LeaveManagement.Application.Feature.LeaveType.Command.UpdateLeaveType
{
    public class UpdateLeaveTypeCommand:IRequest<Unit>
    {
        public int Id { get; init; }
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }
    }
}
