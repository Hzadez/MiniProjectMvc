using MiniProjectMvc.Entities;
using MiniProjectMvc.ViewModels.EventType;

namespace MiniProjectMvc.Service.Interfaces
{
    public interface IEventTypeService : IGenericService<EventTypeVM, EventType>
    {
        Task<EventTypeVM> GetEventTypeByNameAsync(string name);
        Task Update(EventType eventTypeEntity);
    }
}
