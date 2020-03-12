using Autofac;
using NTierApp.BLL;
using NTierApp.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTierApp.PL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        //private readonly Class1 class1; //

        public HomeController(IEmployeeService employeeService)//, Class1 class1)
        {
            //var container = AutofacConfig.ConfigureContainer("DefaultConnection");
            //_employeeService = container.Resolve(typeof(IEmployeeService)) as IEmployeeService;
            _employeeService = employeeService;
            //var x = class1.Get5(); //
        }


        public ActionResult Index()
        {
            var employees = _employeeService.GetAllEmloyees();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}