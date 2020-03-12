using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.DAL
{
    public class IUnitOfWork
    {
        private DatabaseContext db;
        private EmployeeRepository employeeRepository;
        private CompanyRepository companyRepository;

        public UnitOfWork(string ConnectionString)
        {
            db = new DatabaseContext(ConnectionString);
        }

        public IRepository<Employee> Employees
        {
            get
            {
                if(employeeRepository ==null)
                {
                    employeeRepository = new EmployeeRepository(db);
                }
                return employeeRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        //public virtual void Dispose
    }
}
