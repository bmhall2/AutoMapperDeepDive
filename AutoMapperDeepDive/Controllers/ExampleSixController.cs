using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperDeepDive.Models.ExampleFive;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDeepDive.Controllers
{
    [Produces("application/json")]
    [Route("api/ExampleSix")]
    public class ExampleSixController : Controller
    {
        private readonly IMapper _mapper;

        public ExampleSixController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ExampleSixResponse Get()
        {
            var exampleFiveSources = new List<ExampleFiveSource>
            {
                new ExampleFiveSource
                {
                    StringOne = "NCC",
                    NumberOne = 1501
                },
                new ExampleFiveSource
                {
                    StringOne = "NCC",
                    NumberOne = 1501,
                    StringTwo = "A"
                },
                new ExampleFiveSource
                {
                    StringOne = "NCC",
                    NumberOne = 1501,
                    StringTwo = "B"
                }
            };

            var exampleFiveDestination = _mapper.Map<List<ExampleFiveDestination>>(exampleFiveSources);

            return new ExampleSixResponse
            {
                ExampleSixSources = exampleFiveSources,
                ExampleSixDestinations = exampleFiveDestination
            };
        }
    }

    public class ExampleSixResponse
    {
        public List<ExampleFiveSource> ExampleSixSources { get; set; }
        public List<ExampleFiveDestination> ExampleSixDestinations { get; set; }
    }
}