using Magic8Ball.Models;
using Microsoft.AspNetCore.Mvc;
using Magic8Ball.Algorithms;
using Magic8Ball.Mappers;

namespace Magic8Ball.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Magic8Controller : ControllerBase
    {
        [HttpGet("{question}")]
        public ActionResult<BallResult> Get(string question)
        {
            string answer = new Ballgorithm().Shake(question);
            return Ok(Mapper.Map(question, answer));
        }
    }
}
