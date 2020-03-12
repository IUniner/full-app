using Autofac;
using ConsoleApp14.Models;
using NTierApp.BLL;
using NTierApp.BLL.Interfaces;
using System;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AutofacBuilder.ConfigureContainer("DefaultConnection");
            var employeeService = container.Resolve(typeof(IEmployeeService)) as IEmployeeService;

            employeeService.AddEmployee(new NTierApp.BLL.Models.EmployeeModel { FirstName = "Alex", LastName = "Protskevich" });
            var employees = employeeService.GetAllEmloyees();
        }
    }
}
