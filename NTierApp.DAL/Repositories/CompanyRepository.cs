using NTierApp.DAL.Entities;
using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace NTierApp.DAL.Repositories
{
    class CompanyRepository : IRepository<Company>
    {
        private readonly DatabaseContext db;

        public CompanyRepository(DatabaseContext context)
        {
            this.db = context;
        }
        public void Create(Company item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Company Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Company item)
        {
            throw new NotImplementedException();
        }
    }
}
