using Autofac;
using Autofac.Integration.Mvc;
using NTierApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NTierApp.PL
{
    public class AutofacConfig
    {
        public static void ConfigureContainer(string connectionString)
        {
            var builder = AutofacBuilder.GetBuilder(connectionString);
            //builder.RegisterType<Class1>().As<Class1>();//
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
            /*
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().WithParameter("connectionString", connectionString);*/
        }
    }
}
