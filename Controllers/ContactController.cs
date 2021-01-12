using Dotnet5Webapp.Models;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult<IEnumerable<Contact>> Get()
        {
            return contactList;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> Get(int id)
        {
            Contact contact = await Task.Run(()=>contactList.FirstOrDefault(x=>x.ID==id));
            if (contact == null)
                return NotFound(new { Message = "Record has not been found"});
            return Ok(contact);
        }

        // POST api/<ContactController>
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Contact>>> Post([FromBody] Contact model)
        {
            await Task.Run(()=> contactList.Add(model));

            return contactList;
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable<Contact>>> Put(int id, [FromBody] Contact model)
        {
            Contact contact = await Task.Run(()=>contactList.FirstOrDefault(x=>x.ID == id));
            if (contact == null)
                return NotFound();

            contact.NickName = model.NickName;
            contact.isActive = model.isActive;

            return contactList;
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        [Route("api/contact/delete")]
        public async Task<ActionResult<IEnumerable<Contact>>> Delete(int id)
        {
            Contact contact = await Task.Run(() => contactList.FirstOrDefault(x => x.ID == id));
            if (contact == null)
                return NotFound();

            contact.isActive = false;

            return contactList;
        }


        #endregion

        #region Methods
        #endregion

    }
}
