using System;
using System.Collections.Generic;
using APICalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICalculator.Controllers
{
    [Route("api/div")]
    [ApiController]
    public class DivisionControler : ControllerBase
    {
        // POST api/div
        [HttpPost]
        public IActionResult Post([FromBody] Calculator data)
        {
            return StatusCode(200, data.Division());
        }
    }
}
