using Autofac;
using Axis.DataAccess.IRepository;
using Axis.DataAccess.Persistence;
using Axis.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Axis.DataAccess
{
    public class DataAccessModule : Module
    {
        public DataAccessModule()
        {
            
        }

        protected override void Load(ContainerBuilder builder)
        {
           // builder.RegisterType<AxisDbContext>().As<IAxisDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<AxisDbContext>()
                   .As<DbContext>()
                   .As<IAxisDbContext>()
                   .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>().InstancePerLifetimeScope();


            base.Load(builder);
        }
    }
}
