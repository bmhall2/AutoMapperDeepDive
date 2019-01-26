using AutoMapper;
using AutoMapperDeepDive.Models.ExampleOne;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDeepDive.Controllers
{
    [Produces("application/json")]
    [Route("api/ExampleOne")]
    public class ExampleOneController : Controller
    {
        private readonly IMapper _mapper;

        public ExampleOneController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ExampleOneResponse Get()
        {
            var simpleDto = new SimpleDto
            {
                PrimaryKey = 52,
                Name = "Ben Hall",
                Active = true
            };

            var simpleViewModel = _mapper.Map<SimpleViewModel>(simpleDto);

            return new ExampleOneResponse
            {
                SimpleDto = simpleDto,
                SimpleViewModel = simpleViewModel
            };
        }
    }

    public class ExampleOneResponse
    {
        public SimpleDto SimpleDto { get; set; }
        public SimpleViewModel SimpleViewModel { get; set; }
    }
}