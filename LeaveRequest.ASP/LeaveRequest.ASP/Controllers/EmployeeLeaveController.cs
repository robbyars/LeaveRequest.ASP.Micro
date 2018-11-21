using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeaveRequest.ASP.Common.Interface;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.Controllers
{
    public class EmployeeLeaveController : Controller
    {
        private readonly IEmployeeLeaveService _employeeLeaveService;
        public EmployeeLeaveController() { }
        public EmployeeLeaveController(IEmployeeLeaveService employeeLeaveService)
        {
            this._employeeLeaveService = employeeLeaveService;
        }
        // GET: EmployeeLeave
        public ActionResult Index()
        {
            if (Session["Id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login","Login");
            }
        }
        public ActionResult Create(int? id)
        {
            id = Convert.ToInt16(Session["Id"]);
            var employee = _employeeLeaveService.Get(id);
            var employeeleaveparam = new EmployeeLeaveParam(employee);

            IEnumerable<SelectListItem> _leavetype = _employeeLeaveService.LeaveType().Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name

            });
            ViewBag.leavetype = _leavetype;
            return View(employeeleaveparam);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeLeaveParam employeeleaveparam)
        {
            if (ModelState.IsValid)
            {
                _employeeLeaveService.Insert(employeeleaveparam);
                return RedirectToAction("Index");
            }

            return View(employeeleaveparam);
        }
    }
}