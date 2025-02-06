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
            IWorkExperienceRepository workExperienceRepository
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

        }
       
        
        
        
        
        
        
        


        
        public virtual void save() => _context?.SaveChanges();
        public void Dispose() => _context?.Dispose();

    }
    
}
