using System;
using System.Collections.Generic;
using APICalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICalculator.Controllers
{
    [Route("api/mult")]
    [ApiController]
    public class MultiplicationControler : ControllerBase
    {
        // POST api/mult
        [HttpPost]
        public IActionResult Post([FromBody] Calculator data)
        {
            return StatusCode(200, data.Multiplication());
        }
    }
}
