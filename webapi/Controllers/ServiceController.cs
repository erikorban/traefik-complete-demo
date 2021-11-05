using System;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class ServiceController : ControllerBase
    {
        public ServiceController()
        { }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(Environment.GetEnvironmentVariable("MESSAGE"));
        }
    }
}
