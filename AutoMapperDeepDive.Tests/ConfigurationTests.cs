using AutoMapper;
using AutoMapperDeepDive.Profiles;
using Xunit;

namespace AutoMapperDeepDive.Tests
{
    public class ConfigurationTests
    {
        [Fact]
        public void ShouldHaveValidConfiguration()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<ExampleFiveProfile>();
                cfg.AddProfile<SimpleButNotPerfectProfile>();
            });

            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
