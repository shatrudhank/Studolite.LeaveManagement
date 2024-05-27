using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studolite.LeaveManagement.Application.Feature.LeaveType.Query.GetLeaveTypeDetails
{
    public class LeaveTypeDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int DefaultDays { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }

    }
}
