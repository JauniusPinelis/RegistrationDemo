using AutoMapper;
using Registration.Core.Models;
using Registration.Infrastructure.Entities;

namespace Registration.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegistrationEntity, RegistrationModel>();
            CreateMap<DropdownFieldEntity, DropdownFieldModel>();
            CreateMap<DropdownEntity, DropdownModel>();
            CreateMap<QuestionEntity, QuestionModel>();
        }
    }
}
