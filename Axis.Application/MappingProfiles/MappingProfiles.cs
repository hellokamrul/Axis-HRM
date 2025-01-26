using AutoMapper;
using Axis.Application.DTOs;
using Axis.Core.Models;
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
        }

    }
}
