using MiniProjectMvc.Entities;
using MiniProjectMvc.ViewModels.Location;

namespace MiniProjectMvc.Service.Interfaces
{
    public interface ILocationService : IGenericService<LocationVM, Location>
    {
        Task CreateAsync(LocationCreateVM model);
        Task<IEnumerable<LocationVM>> GetLocationsWithCapacityGreaterThan(int capacity);
        Task Update(LocationEditVM model);
    }
}
