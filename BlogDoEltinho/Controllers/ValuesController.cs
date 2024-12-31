using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogDoEltinho.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var value = new string[] { "value1" };
            return value;
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            return null!;
        }
    }
}
