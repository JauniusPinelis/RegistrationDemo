using AutoMapper;
using Registration.Core.Models;
using Registration.Infrastructure.Entities;

namespace Registration.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DropdownField, DropdownFieldDto>();
            CreateMap<Dropdown, DropdownDto>();
            CreateMap<Question, QuestionDto>();
        }
    }
}
