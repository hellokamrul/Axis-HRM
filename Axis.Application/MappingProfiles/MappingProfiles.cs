using AutoMapper;
using Axis.Application.DTOs;
using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.DTOs.HR;
using Axis.Core.Models;
using Axis.Core.Models.HouseKeeping;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.MappingProfiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CompanyDTO, Company>().ReverseMap();

            #region HR Mode & DTO
            CreateMap<EmployeeDTO, Employee>().ReverseMap();
            CreateMap<BankInfoDTO, BankInfo>().ReverseMap();
            CreateMap<ContactInfoDTO, ContactInfo>().ReverseMap();
            CreateMap<EducationDTO, Education>().ReverseMap();
            CreateMap<EmpCertificateDTO, EmpCertificate>().ReverseMap();
            CreateMap<EmployeeAddress, EmployeeAddress>().ReverseMap();
            CreateMap<EmployeeFileDTO, EmployeeFile>().ReverseMap();
            CreateMap<EmpTaxInfoDTO, EmpTaxInfo>().ReverseMap();
            CreateMap<FamilyInfoDTO, FamilyInfo>().ReverseMap();
            CreateMap<JobInformationDTO, JobInformationDTO>().ReverseMap();
            CreateMap<WorkExperienceDTO, WorkExperience>().ReverseMap();

            #endregion

            #region HouseKeeping Model & DTO
            CreateMap<BloodGroup,BloodGroupDTO>().ReverseMap();

            #endregion
        }

    }
}
