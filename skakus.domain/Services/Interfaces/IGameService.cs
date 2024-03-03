using skakus.domain.Entities;

namespace skakus.domain.Services.Interfaces
{
    public interface IGameService
    {
        Task<IEnumerable<Game>> GetAllGames();
    }
}