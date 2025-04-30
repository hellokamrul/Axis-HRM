using Autofac;
using Axis.Application.HR.Services;
using Axis.Application.Services;
using Axis.Application.Services.HouseKeeping;
using Axis.Application.Services.IServices;
using Axis.Application.Services.IServices.Holiday_Leave;
using Axis.Application.Services.IServices.HouseKeeping;
using Axis.Application.Services.IServices.HR;
using Axis.Application.Services.Leave_Holiday;
using Axis.DataAccess.IRepository;
using Axis.DataAccess.Repositories;
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

            #region HR Service
            builder.RegisterType<EmployeeService>().As<IEmployeeService>().InstancePerLifetimeScope();
            builder.RegisterType<BankInfoService>().As<IBankInfoService>().InstancePerLifetimeScope();
            builder.RegisterType<ContactInfoService>().As<IContactInfoService>().InstancePerLifetimeScope();
            builder.RegisterType<EducationService>().As<IEducationService>().InstancePerLifetimeScope();
            builder.RegisterType<EmpCertificateService>().As<IEmpCertificateService>().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeAddressService>().As<IEmployeeAddressService>().InstancePerLifetimeScope();
            builder.RegisterType<EmployeeFileService>().As<IEmployeeFileService>().InstancePerLifetimeScope();
            builder.RegisterType<EmpTaxInfoService>().As<IEmpTaxInfoService>().InstancePerLifetimeScope();
            builder.RegisterType<FamilyService>().As<IFamilyService>().InstancePerLifetimeScope();
            builder.RegisterType<JobInformationService>().As<IJobInformationService>().InstancePerLifetimeScope();
            builder.RegisterType<WorkExperienceService>().As<IWorkExperienceService>().InstancePerLifetimeScope();


            #endregion

            #region HouseKeeping Service

            builder.RegisterType<BloodGroupService>().As<IBloodGroupService>().InstancePerLifetimeScope();
            #endregion

            #region Holiday & Leave Service
            builder.RegisterType<HolidayService>().As<IHolidayService>().InstancePerLifetimeScope();

            #endregion

            base.Load(builder);
        }
    }
}
