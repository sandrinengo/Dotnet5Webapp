using Dotnet5Webapp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dotnet5Webapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        #region PrivateVariables
        private List<Contact> contactList = new List<Contact> {
            new Contact {ID=1, FirstName="Santa", LastName="Claus", NickName="Old man", Place="North Pole" },
            new Contact {ID=2, FirstName="Lizzie", LastName="Keen", NickName="Barbie", Place="Tropical Country" }
        };
        #endregion

        #region HttpVerbs
        // GET: api/<ContactController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return contactList;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ContactController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        #endregion

        #region Methods
        #endregion

    }
}
