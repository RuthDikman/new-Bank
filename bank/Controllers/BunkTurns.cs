using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BunkTurns : ControllerBase
    {
        private readonly ITurnsServices _turnService;
        public BunkTurns(ITurnsServices turnService)
        {
            _turnService = turnService;
        }

        // GET: api/<BunkTurns>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_turnService.GetTurns());
        }

        // GET api/<BunkTurns>/5
        [HttpGet("{start}")]
        public ActionResult Get(DateTime start)
        {
            return Ok(_turnService.GetByStart(start));
        }

        // POST api/<BunkTurns>
        [HttpPost]
        public void Post([FromBody] Turn value)
        {
            _turnService.AddTurn(value);
        }

        // PUT api/<BunkTurns>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Turn turn)
        {
            _turnService.UpdateTurn(id, turn);
        }

        // DELETE api/<BunkTurns>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _turnService.DeleteTurn(id);

        }
    }
}
