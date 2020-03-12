using System.Collections.Generic;

namespace NTierApp.BLL.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<EmployeeModel> Employees { get; set; }
    }
}
