using AutoMapper;
using Axis.Application.DTOs;
using Axis.Application.DTOs.HouseKeeping;
using Axis.Application.DTOs.HR;
using Axis.Application.DTOs.Leave_Holiday;
using Axis.Core.Models;
using Axis.Core.Models.HouseKeeping;
using Axis.Core.Models.HR;
using Axis.Core.Models.Leave_Holiday;
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
            CreateMap<Designation,DesignationDTO>().ReverseMap();
            CreateMap<Department,DepartmentDTO>().ReverseMap();
            CreateMap<Floor,FloorDTO>().ReverseMap();
            CreateMap<Grade,GradeDTO>().ReverseMap();
            CreateMap<Line,LineDTO>().ReverseMap();
            CreateMap<Religion,ReligionDTO>().ReverseMap();
            CreateMap<Section,SectionDTO>().ReverseMap();
            CreateMap<Shift,ShiftDTO>().ReverseMap();
            CreateMap<Unit,UnitDTO>().ReverseMap();

            #endregion


            #region Holiday & Leave
            //// → Create / Update: map the incoming DTO’s lists into your entity
            //CreateMap<HolidayListDTO, HolidayList>();

            //CreateMap<HolidayDTO, Holiday>()
            //    // now map the collection instead of ignoring it
            //    .ForMember(dest => dest.HolidayLists,
            //               opt => opt.MapFrom(src => src.HolidayLists));

            //// ← Read: map entity (with populated HolidayLists) back into DTO
            //CreateMap<HolidayList, HolidayListDTO>();

            //CreateMap<Holiday, HolidayDTO>()
            //    .ForMember(dest => dest.HolidayLists,
            //               opt => opt.MapFrom(src => src.HolidayLists));


            // === Create / Update ===
            // DTO → Entity: map the child list, but ignore any incoming IDs
            CreateMap<HolidayListDTO, HolidayList>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.HolidayId, opt => opt.Ignore());

            CreateMap<HolidayDTO, Holiday>()
                // ignore the incoming Holiday.Id so our ctor’s Guid.NewGuid() sticks
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                // map the list over, now that each element has a new Id
                .ForMember(dest => dest.HolidayLists, opt => opt.MapFrom(src => src.HolidayLists));

            // === Read ===
            // Entity → DTO: copy everything back, including the auto-generated IDs
            CreateMap<HolidayList, HolidayListDTO>();

            CreateMap<Holiday, HolidayDTO>()
                .ForMember(dest => dest.HolidayLists,
                           opt => opt.MapFrom(src => src.HolidayLists));


            // If you ever need to map into your table‐view DTO:
            CreateMap<Holiday, HolidayListTableDTO>()
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.FromDate, opt => opt.MapFrom(s => s.FromDate))
                .ForMember(d => d.ToDate, opt => opt.MapFrom(s => s.ToDate))
                .ForMember(d => d.Country, opt => opt.MapFrom(s => s.Country))
                .ForMember(d => d.Color, opt => opt.MapFrom(s => s.Color))
                // weekend and total logic must be computed in your service or a resolver
                .ForMember(d => d.WeekendCount, opt => opt.Ignore())
                .ForMember(d => d.TotalHolidays, opt => opt.Ignore())
                .ForMember(d => d.Status, opt => opt.Ignore());

            #endregion
        }

    }
}
