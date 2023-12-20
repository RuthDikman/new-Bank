using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Officials : ControllerBase
    {
        private readonly IOfficialsServices _officialsServices;
        public Officials(IOfficialsServices officialsServices)
        {
            _officialsServices = officialsServices;
        }
        // GET: api/<Officials>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_officialsServices.GetOfficials());
        }

        // GET api/<Officials>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_officialsServices.GetById(id));
        }

        // POST api/<Officials>
        [HttpPost]
        public void Post([FromBody] Official value)
        {
            _officialsServices.AddOfficial(value);
        }

        // PUT api/<Officials>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Official official)
        {
            _officialsServices.UpdateOfficial(id, official);
        }

        // DELETE api/<Officials>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _officialsServices.DeleteOfficial(id);

        }
    }
}
