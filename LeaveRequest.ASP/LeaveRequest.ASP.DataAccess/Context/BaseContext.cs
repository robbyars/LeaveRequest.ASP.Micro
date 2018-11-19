using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequest.ASP.DataAccess.Models;

namespace LeaveRequest.ASP.DataAccess.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("LeaveRequest.ASP") { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
