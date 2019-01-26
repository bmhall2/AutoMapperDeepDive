using AutoMapper;
using AutoMapperDeepDive.Models.ExampleTwo;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDeepDive.Controllers
{
    [Produces("application/json")]
    [Route("api/ExampleTwo")]
    public class ExampleTwoController : Controller
    {
        private readonly IMapper _mapper;

        public ExampleTwoController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ExampleTwoResponse Get()
        {
            var simpleButNotPerfectDto = new SimpleButNotPerfectDto
            {
                PrimaryKey = 52,
                Name = "Ben Hall",
                Active = true
            };

            var simpleButNotPerfectViewModel = _mapper.Map<SimpleButNotPerfectViewModel>(simpleButNotPerfectDto);

            return new ExampleTwoResponse
            {
                SimpleButNotPerfectDto = simpleButNotPerfectDto,
                SimpleButNotPerfectViewModel = simpleButNotPerfectViewModel
            };
        }
    }

    public class ExampleTwoResponse
    {
        public SimpleButNotPerfectDto SimpleButNotPerfectDto { get; set; }
        public SimpleButNotPerfectViewModel SimpleButNotPerfectViewModel { get; set; }
    }
}