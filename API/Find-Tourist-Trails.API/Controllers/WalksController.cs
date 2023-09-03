using Find_Tourist_Trails.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Find_Tourist_Trails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        // GET: api/<WalksController>
        [HttpGet]

        // IEnumerables
        public ActionResult<List<WalkModel>> Get()
        {
            List<WalkModel> walksList = new List<WalkModel>();

            walksList.Add(
                new WalkModel { Id = 1, Name = "Walk1", Description = "test", Difficulty = "easy" }
            );
            walksList.Add(new WalkModel { Id = 2, Name = "Walk2", Difficulty = "hard" });

            return walksList;

            //return new string[] { "value1", "value2" };
        }

        // GET api/<WalksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WalksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WalksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WalksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
