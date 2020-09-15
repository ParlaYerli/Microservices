using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Uzman1", "Uzman2", "Uzman3", "Uzman4", "Uzman5", };
        }

        [HttpGet("{id}")]
        public int GetById(int id)
        {
            return id;
        }


    }
}