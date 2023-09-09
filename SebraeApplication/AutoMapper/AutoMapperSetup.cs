
using Application.Models;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class AutoMapperSetup: Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<CEPViewModel, CEPDTO>().ReverseMap();
            CreateMap<ContaViewModel, ContaDTO>().ReverseMap();
        }
    }
}
