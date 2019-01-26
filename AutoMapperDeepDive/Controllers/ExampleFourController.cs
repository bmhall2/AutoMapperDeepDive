using AutoMapper;
using AutoMapperDeepDive.Models.ExampleThree;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDeepDive.Controllers
{
    [Produces("application/json")]
    [Route("api/ExampleFour")]
    public class ExampleFourController : Controller
    {
        private readonly IMapper _mapper;

        public ExampleFourController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ExampleFourResponse Get()
        {
            var flatViewModel = new FlatViewModel
            {
                Id = 52,
                InnerDomainObjectName = "Ben Hall",
                InnerDomainObjectId = 365
            };

            var complexDomainObject = _mapper.Map<ComplexDomainObject>(flatViewModel);

            return new ExampleFourResponse
            {
                FlatViewModel = flatViewModel,
                ComplexDomainObject = complexDomainObject
            };
        }
    }

    public class ExampleFourResponse
    {
        public FlatViewModel FlatViewModel { get; set; }
        public ComplexDomainObject ComplexDomainObject { get; set; }
    }
}