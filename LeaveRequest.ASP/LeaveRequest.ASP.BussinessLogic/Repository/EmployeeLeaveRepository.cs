using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.Common.Interface.Application;
using LeaveRequest.ASP.DataAccess.Context;
using LeaveRequest.ASP.DataAccess.Models;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.BussinessLogic.Repository
{
    public class EmployeeLeaveRepository : IEmployeeLeaveRepository
    {
        BaseContext _context = new BaseContext();
        bool status = false;
        
        public Employee Get(int? id)
        {
            if (id == null)
            {
                Console.Write("id is null");
            }
            Employee employee = _context.Employees.Include("Departments").Include("Departments.Companies").SingleOrDefault(x => x.Id == id);
            if (employee == null)
            {
                Console.Write("Employee Has not Value");
            }
            return employee;
        }
        
        public bool Insert(EmployeeLeaveParam employeeleaveparam)
        {
            var emp = _context.Employees.Find(employeeleaveparam.EmployeeId);
            var type = _context.LeaveTypes.Find(Convert.ToInt16(employeeleaveparam.LeaveType));
            var push = new EmployeeLeave(employeeleaveparam);
            push.Employees = emp;
            push.LeaveTypes = type;
            _context.EmployeeLeaves.Add(push);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public Employee GetDetails(EmployeeParam employeeparam)
        {
            if (employeeparam.Email == null && employeeparam.Password == null)
            {
                Console.Write("employee is null");
            }
            Employee employee = _context.Employees.SingleOrDefault(a=>a.Email==employeeparam.Email && a.Password==employeeparam.Password);
            if (employee == null)
            {
                Console.Write("Employee Has not Value");
            }
            return employee;
        }
        
        public LeaveType GetTypeLeave(int? id)
        {
            if (id == null)
            {
                Console.Write("id is null");
            }
            LeaveType leavetype = _context.LeaveTypes.SingleOrDefault(x => x.Id == id);
            if (leavetype == null)
            {
                Console.Write("Leave Type Has not Value");
            }
            return leavetype;
        }

        public List<LeaveType> LeaveType()
        {
            return _context.LeaveTypes.Where(x => x.IsDelete.Equals(false)).ToList();
        }
    }
}
