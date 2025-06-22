using MiniProjectMvc.Entities;
using MiniProjectMvc.ViewModels.Event;

namespace MiniProjectMvc.Service.Interfaces
{
    public interface IEventService : IGenericService<EventVM, Event>
    {
        Task<IEnumerable<EventVM>> GetAllEventsWithDetailsAsync();
        Task<EventVM> GetEventByIdWithDetailsAsync(int id); 
        Task<EventVM> CreateEventAsync(EventCreateVM model);
        Task<EventVM> UpdateEventAsync(EventEditVM model);
        Task<List<Event>> GetCurrentEventsAsync();

    }
}
