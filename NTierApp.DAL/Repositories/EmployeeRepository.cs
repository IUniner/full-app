using NTierApp.DAL.Entities;
using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NTierApp.DAL.Repositories
{
    class EmployeeRepository : IRepository<Employee>
    {
        private readonly DatabaseContext db;

        public EmployeeRepository(DatabaseContext context)
        {
            this.db = context;
        }
        public void Create(Employee item)
        {
            db.Employees.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public void Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}