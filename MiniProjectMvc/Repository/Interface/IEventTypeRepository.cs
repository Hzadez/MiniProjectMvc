using MiniProjectMvc.Entities;

namespace MiniProjectMvc.Repository.Interface
{
    public interface IEventTypeRepository : IGenericRepository<EventType>
    {
        Task<EventType> GetEventTypeByNameAsync(string name);
    }
}
