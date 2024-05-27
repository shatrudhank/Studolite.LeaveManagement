using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studolite.LeaveManagement.Application.Feature.LeaveType.Command.CreateLeaveType
{
    public class CreateLeaveTypeCommand:IRequest<int>
    {
        public string Name {  get; set; }=string.Empty;
        public int DefaultDays { get; set; }
    }
}
