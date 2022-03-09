using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LEIAMAIS.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElimarController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Elimar A";
        }

        [HttpGet("{idade}")]
        public string Get(string idade)
        {
            string nomeComIdade = $"Elimar A : {idade}";
            return nomeComIdade;
        }

        [HttpPost("{teste}")]
        public string Post(string teste)
        {
            return "Chegou o Post";
        }

        [HttpPut]
        public string Put(string teste)
        {
            return "Ñ";
        }

        [HttpDelete]
        public void Delete(int id)
        {
            
        }
    }
}
