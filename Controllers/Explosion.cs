using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{s}")]
        public string Explosion(string s)
        {
            return string.Join("", s.Select(explode => new String(explode, int.Parse(explode.ToString()))));
        }
    }
}