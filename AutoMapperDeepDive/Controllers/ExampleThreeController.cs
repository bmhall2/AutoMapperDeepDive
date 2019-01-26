using AutoMapper;
using AutoMapperDeepDive.Models.ExampleThree;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDeepDive.Controllers
{
    [Produces("application/json")]
    [Route("api/ExampleThree")]
    public class ExampleThreeController : Controller
    {
        private readonly IMapper _mapper;

        public ExampleThreeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ExampleThreeResponse Get()
        {
            var complexDomainObject = new ComplexDomainObject
            {
                Id = 52,
                InnerDomainObject = new InnerDomainObject
                {
                    Id = 365,
                    Name = "Ben Hall"
                }
            };

            var flatViewModel = _mapper.Map<FlatViewModel>(complexDomainObject);

            return new ExampleThreeResponse
            {
                ComplexDomainObject = complexDomainObject,
                FlatViewModel = flatViewModel
            };
        }
    }

    public class ExampleThreeResponse
    {
        public ComplexDomainObject ComplexDomainObject { get; set; }
        public FlatViewModel FlatViewModel { get; set; }
    }
}