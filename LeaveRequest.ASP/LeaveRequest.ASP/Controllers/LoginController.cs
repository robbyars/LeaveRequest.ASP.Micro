using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeaveRequest.ASP.Common.Interface;
using LeaveRequest.ASP.DataAccess.Param;

namespace LeaveRequest.ASP.Controllers
{
    public class LoginController : Controller
    {
        private readonly IEmployeeLeaveService _loginService;
        public LoginController() { }
        public LoginController(IEmployeeLeaveService loginService)
        {
            this._loginService = loginService;
        }
        // GET: Login
        public ActionResult Index()
        {
            if (Session["Id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(EmployeeParam employeeparam)
        {
            if (ModelState.IsValid)
            {
                var obj = _loginService.GetDetails(employeeparam);
                if (obj != null)
                    {
                        Session["Id"] = obj.Id.ToString();
                        Session["Email"] = obj.Name.ToString();
                        return RedirectToAction("Index","EmployeeLeave");
                    }
            }
            return View(employeeparam);
        }
    }
}