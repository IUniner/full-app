using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DatabaseContext())
            {
                /*var company = new Models.Company { Id = 1, Name = "Belitsoft" };
                db.Companies.Add(company);
                var employee = new Models.Employee { Identifier = 1, FirstName = "Ilya", LastName = "Lelia", Age = 19 };//, CompanyId = 1 };
                employee.Companies.Add(company);
                db.Employees.Add(employee);
                db.SaveChanges();*/
                db.Users.Add(new User { Id = 1, Login = "First User" });
                db.Users.Add(new User { Id = 2, Login = "Second User" });
                db.Admins.Add(new Admin { Id = 3, Login = "First Admin", HasSpecialPermissions = true });
                db.Admins.Add(new Admin { Id = 4, Login = "Second Admin" });
                db.SaveChanges();
            }

            using (var db = new DatabaseContext())
            {
                var companies = db.Companies.Include(p => p.Employees).ToList();
                /*IQueryable<User> users = db.Users;
                users = users.Where(p => p.Login.StartsWith("A"));
                users = users.Where(p => p.Email.EndsWith(".com"));
                var x = users.ToList();

                IEnumerable<User> newUsers = db.Users;
                users = newUsers.Where(p => p.Login.StartsWith("A"));
                users = newUsers.Where(p => p.Email.EndsWith(".com"));
                var y = newUsers.ToList();
                //var admin = db.Admins.ToList();*/
                //var companyWithEmployeesCount = 
                //db.Companies.Select(p => new { p.Name, Count = p.Employees.Count() }).ToList();
            }
        }
    }
}
