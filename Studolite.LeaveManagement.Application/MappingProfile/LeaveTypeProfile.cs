﻿using AutoMapper;
using Studolite.LeaveManagement.Application.Feature.LeaveType.Query.GetAllLeaveType;
using Studolite.LeaveManagement.Application.Feature.LeaveType.Query.GetLeaveTypeDetails;
using Studolite.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studolite.LeaveManagement.Application.MappingProfile
{
    internal class LeaveTypeProfile:Profile
    {

        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDTO,LeaveType>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDetailDTO>();
        }

    }
    
}
