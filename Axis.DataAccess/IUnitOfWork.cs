using Axis.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Companies { get; }

        #region HR Interface
        IEmployeeRepository Employees { get; }
        IBankInfoRepository  BankInfo { get; }
        IContactInfoRepository ContactInfo { get; }
        IEducationRepository Education { get; }
        IEmpCertificateRepository EmpCertificate { get; }
        IEmployeeAddressRepository EmployeeAddress { get; }
        IEmployeeFileRepository EmployeeFile { get; }
        IEmpTaxInfoRepository EmpTaxInfo { get; }
        IFamilyInfoRepository FamilyInfo { get; }
        IJobInformationRepository JobInformation { get; }
        IWorkExperienceRepository WorkExperience { get; }

        //Attendance_Leave

        IHolidayRepository Holidays { get; }
        IHolidayTemplateRepository HolidayTemplates { get; }



        #endregion

        #region HouseKeeping Interface
        IBloodGroupRepository BloodGroups { get; }
        IDepartmentRepository Departments { get; }
        IDesignationRepository Designations { get; }
        IFloorRepository Floors { get; }
        ISectionRepository Sections { get; }
        IShiftRepository Shifts { get; }
        IUnitRepository Units { get; }
        IReligionRepository Religions { get; }
        ILineRepository Lines { get; }
        IGradeRepository Grades { get; }    

        #endregion
        void save();
    }
}
