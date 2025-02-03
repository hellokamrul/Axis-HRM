using AutoMapper;
using Axis.Application.DTOs;
using Axis.Core.Models;
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
            CreateMap<EmployeeDTO, Employee>().ReverseMap();
        }

    }
}
