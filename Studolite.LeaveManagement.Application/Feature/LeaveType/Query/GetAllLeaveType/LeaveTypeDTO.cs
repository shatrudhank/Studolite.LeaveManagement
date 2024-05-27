﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studolite.LeaveManagement.Application.Feature.LeaveType.Query.GetAllLeaveType
{
    public class LeaveTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int DefaultDays { get; set; }
    }
}
