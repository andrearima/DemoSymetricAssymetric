﻿using DemoNet5.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoNet5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssymetricController : ControllerBase
    {
        [HttpGet]
        [Authorize(AuthenticationSchemes = "assymetric")]
        public IActionResult Get()
        {
            return Ok("jwt assymetric ok.");
        }


        [HttpPost]
        public IActionResult GerarToken()
        {
            return Ok(new TokenService().GerarAssymetric());
        }
    }
}
