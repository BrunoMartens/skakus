using Microsoft.AspNetCore.Mvc;
using skakus.domain.Entities;
using skakus.domain.Services.Interfaces;

namespace skakus.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;
        private readonly IGameService gameService;

        public GameController(ILogger<GameController> logger, IGameService gameService)
        {
            _logger = logger;
            this.gameService = gameService;
        }

        [HttpGet(Name = "GetAllGames")]
        public async Task<IEnumerable<Game>> GetAll()
        {
            return await gameService.GetAllGames();
        }
    }
}
