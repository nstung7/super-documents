using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using app01.Extensions;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using app01.Models;
using System;

namespace app01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        readonly IDistributedCache _cache;
        public PeopleController(IDistributedCache cache)
        {
            _cache = cache;
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string id)
        {
            var data = await _cache.GetRecordAsync<Person>(id);
            return Ok(data);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post(Person person)
        {
            if (person == null)
                return BadRequest();
            await _cache.SetRecordAsync($"person_01", person);
            return Created(nameof(Post), person);
        }
    }
}
