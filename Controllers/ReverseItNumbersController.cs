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
    public class ReverseItNumbersController : ControllerBase
    {
        private readonly ReverseItNumbersServices _reverseItNumbersServices;

        public ReverseItNumbersController(ReverseItNumbersServices reverseItNumbersServices)
        {
            _reverseItNumbersServices = reverseItNumbersServices;
        }

        [HttpGet]
        [Route("ReverseIt/{num}")]

        public string ReverseItNum(string num)
        {
            return _reverseItNumbersServices.ReverseItNum(num);
        }
    }
}