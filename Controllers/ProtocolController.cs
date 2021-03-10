using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using Microsoft.AspNetCore.Cors;

namespace api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProtocolController : ControllerBase
    {

        // GET: api/Protocol
        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public ProtocolContainer Get()
        {
            return APIData.GetInboundObject();
        }

        // GET: api/Protocol/5
        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Protocol
        [EnableCors("AnotherPolicy")]
        [HttpPost]
        public void Post([FromBody] ProtocolContainer value)
        {
            Console.WriteLine(value.protocol.description);
            APIData.SetInboundObject(value);
        }

        // PUT: api/Protocol/5
        [EnableCors("AnotherPolicy")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Protocol/5
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
