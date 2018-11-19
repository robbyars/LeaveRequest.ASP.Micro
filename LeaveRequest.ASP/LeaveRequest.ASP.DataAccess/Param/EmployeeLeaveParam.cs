using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Models;

namespace LeaveRequest.ASP.DataAccess.Param
{
    public class EmployeeLeaveParam
    {
        public int Id { get; set; }
        public string Employees { get; set; }
        public string LeaveTypes { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int LeaveDays { get; set; }
        public string Backup { get; set; }
        public string Note { get; set; }
        public string ApprovalStatus { get; set; }
        public int ThisYearBefore { get; set; }
        public int LastYearBefore { get; set; }
        public int ThisYearAfter { get; set; }
        public int LastYearAfter { get; set; }

        public EmployeeLeaveParam() { }
        public EmployeeLeaveParam(EmployeeLeave employeeleave)
        {
            this.Id = employeeleave.Id;
            this.Employees = employeeleave.Employees.Name;
            this.LeaveTypes = employeeleave.LeaveTypes.Name;
            this.StartDate = employeeleave.StartDate;
            this.EndDate = employeeleave.EndDate;
            this.LeaveDays = employeeleave.LeaveDays;
            this.Backup = employeeleave.Backup;
            this.Note = employeeleave.Note;
            this.ApprovalStatus = employeeleave.ApprovalStatus;
            this.ThisYearBefore = employeeleave.ThisYearBefore;
            this.LastYearBefore = employeeleave.LastYearBefore;
            this.ThisYearAfter = employeeleave.LastYearAfter;
            this.LastYearAfter = employeeleave.LastYearAfter;
        }
    }
}
