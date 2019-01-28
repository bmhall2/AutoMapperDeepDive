using AutoMapper;
using AutoMapperDeepDive.Models.ExampleFive;

namespace AutoMapperDeepDive.Profiles
{
    public class ExampleFiveProfile : Profile
    {
        public ExampleFiveProfile()
        {
            CreateMap<ExampleFiveSource, ExampleFiveDestination>()
                .ForMember(dest => dest.Display, opt => opt.MapFrom<ExampleFiveResolver>());
        }
    }

    public class ExampleFiveResolver : IValueResolver<ExampleFiveSource, ExampleFiveDestination, string>
    {
        public const int DFIN_MAGIC_NUMBER = 200;

        public string Resolve(ExampleFiveSource source, ExampleFiveDestination destination, string destMember, ResolutionContext context)
        {
            return $"{source.StringOne}-{(source.NumberOne + DFIN_MAGIC_NUMBER).ToString()}{(!string.IsNullOrEmpty(source.StringTwo) ? $"-{source.StringTwo}" : string.Empty)}";
        }
    }
}
