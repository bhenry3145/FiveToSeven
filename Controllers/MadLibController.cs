using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveToSeven.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;

        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet]
        [Route("Madlib/{place}/{adjective}/{animal}/{adverb}/{presentTenseVerb}/{humanName}/{amount}/{itemPlural}/{vehicle}/{country}")]

        public string FormMadLib(string place, string adjective, string animal, string adverb, string presentTenseVerb, string humanName, string amount, string itemPlural, string vehicle, string country)
        {
            return _madLibServices.FormMadLib(place, adjective, animal, adverb, presentTenseVerb, humanName, amount, itemPlural, vehicle, country);
        }
    }
}