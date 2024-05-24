namespace Studolite.LeaveManagement.Domain
{
    public class LeaveAllocation:BaseEntity
    {
        public int LeaveTypeId {  get; set; }

        public LeaveType? LeaveType { get; set; }

        public int Period {  get; set; }
    }
}
