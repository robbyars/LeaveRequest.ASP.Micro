using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.DataAccess.Models
{
    public class EmployeeLeave : BaseModel
    {
        public Employee Employees { get; set; }
        public LeaveType LeaveTypes { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public int? LeaveDays { get; set; }
        public string Backup { get; set; }
        public string Note { get; set; }
        public string ApprovalStatus { get; set; }
        public int? ThisYearBefore { get; set; }
        public int? LastYearBefore { get; set; }
        public int? ThisYearAfter { get; set; }
        public int? LastYearAfter { get; set; }
        public EmployeeLeave() { }
        public EmployeeLeave(EmployeeLeaveParam employeeleaveparam)
        {
            this.StartDate = employeeleaveparam.StartDate;
            this.EndDate = employeeleaveparam.EndDate;
            this.LeaveDays = employeeleaveparam.LeaveDays;
            this.Backup = employeeleaveparam.Backup;
            this.Note = employeeleaveparam.Note;
            this.ApprovalStatus = employeeleaveparam.ApprovalStatus;
            this.ThisYearBefore = employeeleaveparam.ThisYearBefore;
            this.LastYearBefore = employeeleaveparam.LastYearBefore;
            this.ThisYearAfter = employeeleaveparam.LastYearAfter;
            this.LastYearAfter = employeeleaveparam.LastYearAfter;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
            
        }
        public virtual void Update(EmployeeLeaveParam employeeleaveparam)
        {
            this.Id = employeeleaveparam.Id;
            this.StartDate = employeeleaveparam.StartDate;
            this.EndDate = employeeleaveparam.EndDate;
            this.LeaveDays = employeeleaveparam.LeaveDays;
            this.Backup = employeeleaveparam.Backup;
            this.Note = employeeleaveparam.Note;
            this.ApprovalStatus = employeeleaveparam.ApprovalStatus;
            this.ThisYearBefore = employeeleaveparam.ThisYearBefore;
            this.LastYearBefore = employeeleaveparam.LastYearBefore;
            this.ThisYearAfter = employeeleaveparam.LastYearAfter;
            this.LastYearAfter = employeeleaveparam.LastYearAfter;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
