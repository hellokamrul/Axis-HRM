using Autofac;
using Axis.Application.Services;
using Axis.Application.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           //builder.RegisterType<CompanyService>As<ICompanyService>().Ins;
           builder.RegisterType<CompanyService>().As<ICompanyService>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
