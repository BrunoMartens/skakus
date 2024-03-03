using skakus.data.Entities;

namespace skakus.data.Repositories.Interfaces
{
    public interface IGameRepository
    {
        Task<IEnumerable<Game>> GetAll();
    }
}