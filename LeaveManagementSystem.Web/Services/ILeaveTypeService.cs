using System;
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.Services;

public interface ILeaveTypeService
{
       Task Create(LeaveTypeCreateVM model);
       Task Edit(LeaveTypeEditVM model);
       Task<T?> Get<T>(int id) where T : class;
       Task<List<LeaveTypeReadOnlyVM>> GetAll();
       Task Remove(int id);
       bool LeaveTypeExists(int id);
       Task<bool> CheckIfLeaveTypeNameExists(string name);
       Task<bool> CheckIfLeaveTypeNameExists(LeaveTypeEditVM leaveTypeEdit);


}