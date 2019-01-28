using AutoMapper;
using AutoMapperDeepDive.Models.ExampleFive;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDeepDive.Controllers
{
    [Produces("application/json")]
    [Route("api/ExampleFive")]
    public class ExampleFiveController : Controller
    {
        private readonly IMapper _mapper;

        public ExampleFiveController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ExampleFiveResponse Get()
        {
            var exampleFiveSource = new ExampleFiveSource
            {
                StringOne = "NCC",
                NumberOne = 1501
            };

            var exampleFiveDestination = _mapper.Map<ExampleFiveDestination>(exampleFiveSource);

            return new ExampleFiveResponse
            {
                ExampleFiveSource = exampleFiveSource,
                ExampleFiveDestination = exampleFiveDestination
            };
        }
    }

    public class ExampleFiveResponse
    {
        public ExampleFiveSource ExampleFiveSource { get; set; }
        public ExampleFiveDestination ExampleFiveDestination { get; set; }
    }
}