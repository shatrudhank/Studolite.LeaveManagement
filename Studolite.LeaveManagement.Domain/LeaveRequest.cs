using Microsoft.VisualBasic;

namespace Studolite.LeaveManagement.Domain
{
    public class LeaveRequest:BaseEntity
    {
        public DateAndTime StartDate { get; set; }
        public DateAndTime EndDate { get; set; }


        public LeaveType? LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        public DateTime DateRequested { get; set; }

        public string? RequestComment { get; set; }

        public bool Approved { get; set; }

        public bool Cancelled { get; set; }

        public int EmployeeId { get; set; }
    }
}