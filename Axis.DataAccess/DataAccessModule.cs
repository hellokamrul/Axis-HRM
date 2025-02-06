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
           
            
            #region HR

            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>().InstancePerLifetimeScope();
            builder.RegisterType<BankInfoRepository>().As<IBankInfoRepository>().InstancePerLifetimeScope();
            builder.RegisterType<ContactInfoRepository>().As<IContactInfoRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EducationRepository>().As<IEducationRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EmpCertificateRepository>().As<IEmpCertificateRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeAddressRepository>().As<IEmployeeAddressRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeFileRepository>().As<IEmployeeFileRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EmpTaxInfoRepository>().As<IEmpTaxInfoRepository>().InstancePerLifetimeScope();
            builder.RegisterType<FamilyInfoRepository>().As<IFamilyInfoRepository>().InstancePerLifetimeScope();
            builder.RegisterType<JobInformationRepository>().As<IJobInformationRepository>().InstancePerLifetimeScope();
            builder.RegisterType<WorkExperienceRepository>().As<IWorkExperienceRepository>().InstancePerLifetimeScope();
            
            
            #endregion


            base.Load(builder);
        }
    }
}
