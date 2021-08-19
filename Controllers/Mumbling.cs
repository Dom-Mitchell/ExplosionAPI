using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{s}")]
        public string Mumbling(string s)
        {
            return String.Join("-", s.Select((letters, i) => Char.ToUpper(letters) + new String(Char.ToLower(letters), i)));
        }
    }
}