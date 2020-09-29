using AutoMapper;
using DC = Session6_WebApi.API.DataContracts;
using S = Session6_WebApi.Services.Model;

namespace Session6_WebApi.IoC.Configuration.AutoMapper.Profiles
{
    public class APIMappingProfile : Profile
    {
        public APIMappingProfile()
        {
            CreateMap<DC.User, S.User>().ReverseMap();
            CreateMap<DC.Address, S.Address>().ReverseMap();
        }
    }
}
