using Axis.DataAccess.IRepository;
using Axis.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext _context;

        #region Repositories
        public ICompanyRepository Companies { get; private set; }


        #region HR
        public IEmployeeRepository Employees { get; private set; }
        public IBankInfoRepository BankInfo { get; private set; }
        public IContactInfoRepository ContactInfo { get; private set; }
        public IEducationRepository Education { get; private set; }
        public IEmpCertificateRepository EmpCertificate { get; private set; }
        public IEmployeeAddressRepository EmployeeAddress { get; private set; }
        public IEmployeeFileRepository EmployeeFile { get; private set; }
        public IEmpTaxInfoRepository EmpTaxInfo { get; private set; }
        public IFamilyInfoRepository FamilyInfo { get; private set; }
        public IJobInformationRepository JobInformation { get; private set; }
        public IWorkExperienceRepository WorkExperience { get; private set; }

        public IBloodGroupRepository BloodGroups { get; private set; }

        public IDepartmentRepository Departments { get; private set; }

        public IDesignationRepository Designations {get; private set;}

        public IFloorRepository Floors {get; private set;}

        public ISectionRepository Sections {get; private set;}

        public IShiftRepository Shifts {get; private set;}

        public IUnitRepository Units {get; private set;}

        public IReligionRepository Religions {get; private set;}

        public ILineRepository Lines {get; private set;}

        public IGradeRepository Grades {get; private set;}

        #endregion


        #endregion
        public UnitOfWork(
            DbContext context,
            ICompanyRepository companyRepository,
            IEmployeeRepository employeeRepository,
            IBankInfoRepository bankInfoRepository,
            IContactInfoRepository contactInfoRepository,
            IEducationRepository educationRepository,
            IEmpCertificateRepository empCertificateRepository,
            IEmployeeAddressRepository employeeAddressRepository,
            IEmployeeFileRepository employeeFileRepository,
            IEmpTaxInfoRepository empTaxInfoRepository,
            IFamilyInfoRepository familyInfoRepository,
            IJobInformationRepository jobInformationRepository,
            IWorkExperienceRepository workExperienceRepository,
            IBloodGroupRepository bloodGroupRepository,
            IDepartmentRepository departmentRepository,
            IDesignationRepository designationRepository,
            IFloorRepository floorRepository,
            ISectionRepository sectionRepository,
            IShiftRepository shiftRepository,
            IUnitRepository unitRepository,
            IReligionRepository religionRepository,
            ILineRepository lineRepository,
            IGradeRepository gradeRepository
            )


        {
            _context = context;
            Companies = companyRepository;
            Employees = employeeRepository;
            BankInfo = bankInfoRepository;
            ContactInfo = contactInfoRepository;
            Education = educationRepository;
            EmpCertificate = empCertificateRepository;
            EmployeeAddress = employeeAddressRepository;
            EmployeeFile = employeeFileRepository;
            EmpTaxInfo = empTaxInfoRepository;
            FamilyInfo = familyInfoRepository;
            JobInformation = jobInformationRepository;
            WorkExperience = workExperienceRepository;
            BloodGroups = bloodGroupRepository;
            Departments = departmentRepository;
            Designations = designationRepository;
            Floors = floorRepository;
            Sections = sectionRepository;
            Shifts = shiftRepository;
            Units = unitRepository;
            Religions = religionRepository;
            Lines = lineRepository;
            Grades = gradeRepository;


        }
       
        
        
        
        
        
        
        


        
        public virtual void save() => _context?.SaveChanges();
        public void Dispose() => _context?.Dispose();

    }
    
}
