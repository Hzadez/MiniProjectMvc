using MiniProjectMvc.Entities;

namespace MiniProjectMvc.Repository.Interface
{
    public interface ILocationRepository : IGenericRepository<Location>
    {
        Task<IEnumerable<Location>> GetLocationsByCapacityAsync(int capacity);
    }
}
