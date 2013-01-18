using MVC4_Using_Unity.ServicesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_Using_Unity.Controllers
{
    public class EmployeeInfoController : Controller
    {

        private readonly IEmployeeInfoService EmployeeInfoService;

        /// <summary>
        /// Injecting dependency using constructor
        /// </summary>
        /// <param name="empserv"></param>
        public EmployeeInfoController(IEmployeeInfoService empserv)
        {
            EmployeeInfoService = empserv;
        }

        //
        // GET: /EmployeeInfo/

        public ActionResult Index()
        {
            var Employees = EmployeeInfoService.GetEmployees();
            return View(Employees);
        }

    }
}
