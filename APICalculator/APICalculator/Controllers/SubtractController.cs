using System;
using System.Collections.Generic;
using APICalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICalculator.Controllers
{
    [Route("api/sub")]
    [ApiController]
    public class SubtractControler : ControllerBase
    {
        // POST api/sub
        [HttpPost]
        public IActionResult Post([FromBody] Calculator data)
        {
            return StatusCode(200, data.Subtraction());
        }
    }
}
