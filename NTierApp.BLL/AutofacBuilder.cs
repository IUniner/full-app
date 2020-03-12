using Autofac;
using NTierApp.BLL.Interfaces;
using NTierApp.DAL;
using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL
{
    public class AutofacBuilder
    {
        public static ContainerBuilder GetBuilder(string connectionString)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().WithParameter("connectionString", connectionString);
            return builder;

        }
    }
}
