using API.Models;
using AutoMapper;
using Service.ViewModel.KPI;
using System;
using System.Collections.Generic;
using System.Text;


namespace Service.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<KPI, KPIViewModel>();
            CreateMap<KPIViewModel, KPI>();
        }
    }
}
