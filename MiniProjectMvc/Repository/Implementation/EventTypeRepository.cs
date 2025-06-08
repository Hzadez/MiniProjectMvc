using MiniProjectMvc.Data;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;

namespace MiniProjectMvc.Repository.Implementation
{
    public class EventTypeRepository : GenericRepository<EventType>, IEventTypeRepository
    {
        public EventTypeRepository(MiniProjectDb context) : base(context) { }

    }
}
