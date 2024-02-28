using EventManager.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EventManager.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class EventController : ControllerBase
    {
        public EventController()
        {

        }

        [HttpGet("{id}")]
        public string GetEvent(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] EventDto eventDto)
        {
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
