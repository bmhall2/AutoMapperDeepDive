using AutoMapper;
using AutoMapperDeepDive.Models.ExampleTwo;

namespace AutoMapperDeepDive.Profiles
{
    public class SimpleButNotPerfectProfile : Profile
    {
        public SimpleButNotPerfectProfile()
        {
            CreateMap<SimpleButNotPerfectDto, SimpleButNotPerfectViewModel>()
                //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PrimaryKey))
                //.ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Name))
                ;
        }
    }
}
