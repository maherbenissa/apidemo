﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apidemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        

         private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[]{"maher ben issa", "ben issa maher", "benissamaher"};
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "maher ben issa";
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<string> All()
        {
            return new string[]{"2 maher ben issa", "3 ben issa maher"};
        }


        [HttpGet]
        [Route("full")]
        public IEnumerable<string> full()
        {
            return new string[]{"full maher ben issa", "full ben issa maher"};
        }
 
    }
}
