using AutoMapper;
using skakus.data.Repositories.Interfaces;
using skakus.domain.Entities;
using skakus.domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skakus.domain.Services
{
    public class GameService : IGameService
    {
        private readonly IMapper mapper;
        private readonly IGameRepository gameRepository;

        public GameService(IMapper mapper, IGameRepository gameRepository)
        {
            this.mapper = mapper;
            this.gameRepository = gameRepository;
        }

        public async  Task<IEnumerable<Game>> GetAllGames()
        {
            return mapper.Map<IEnumerable<Game>>(await gameRepository.GetAll());
        }
    }
}
