using Microsoft.AspNetCore.Mvc;
using RockPaperScissorsInjection.Common;
using RockPaperScissorsInjection.WebApi.Gameplay;

namespace RockPaperScissorsInjection.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GameController (IRpsStrategy rpsStrategy) : ControllerBase
    {

        [HttpGet("throw/{opponentThrow}")]
        public IActionResult Throw(string opponentThrow)
        {
            return Ok(rpsStrategy.Throw(Enum.Parse<Sign>(opponentThrow)).ToString());
        }
    }
}
