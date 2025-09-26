using System;
using AutoMapper;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.MigrationProfiles;

public class AutoMapperProfile : Profile
{
       public AutoMapperProfile()
       {
              CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
              CreateMap<LeaveTypeCreateVM, LeaveType>();
              CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();

       }
}
