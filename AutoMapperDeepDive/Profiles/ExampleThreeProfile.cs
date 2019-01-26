using AutoMapper;
using AutoMapperDeepDive.Models.ExampleThree;

namespace AutoMapperDeepDive.Profiles
{
    public class ExampleThreeProfile : Profile
    {
        public ExampleThreeProfile()
        {
            CreateMap<ComplexDomainObject, FlatViewModel>()
                //.ReverseMap()
                ;
        }
    }
}
