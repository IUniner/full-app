using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL.Repositories
{
    class EmployeeRepository:IRepository<Employee>
    {
        private readonly DatabaseContext db;

        public EmployeeRepository(DatabaseContext context)
        {
            this.db = context;
        }

        public void Create(EmployeeRepository item)
        {
            db.Employees.Add(item);
        }

        public void Delete(EmployeeRepository item)
        {
            db.Employees.Remove(item);
        }
    }
}
