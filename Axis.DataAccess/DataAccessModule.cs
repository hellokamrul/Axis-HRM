using Autofac;
using Axis.DataAccess.Persistence;


namespace Axis.DataAccess
{
    public class DataAccessModule : Module
    {
        public DataAccessModule()
        {
            
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AxisDbContext>().As<IAxisDbContext>().InstancePerLifetimeScope();





            base.Load(builder);
        }
    }
}
