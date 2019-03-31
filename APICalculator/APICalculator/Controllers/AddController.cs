using System;
using System.Collections.Generic;
using APICalculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICalculator.Controllers
{
    [Route("api/add")]
    [ApiController]
    public class AddControler : ControllerBase
    {
        // POST api/add
        [HttpPost]
        public IActionResult Post([FromBody] Calculator data)
        {
            return StatusCode(200, data.Addition());
        }
    }
}
