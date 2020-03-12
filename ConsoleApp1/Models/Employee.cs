using System;
using System.Collections.Generic;
using ServiceStack.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Employee
    {
        public Employee()
        {
            Companies = new List<Company>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        //public int CompanyId { get; set; }
        //public virtual Company Company { get; set; }
        public ICollection<Company> Companies { get; set; }
    }
}
