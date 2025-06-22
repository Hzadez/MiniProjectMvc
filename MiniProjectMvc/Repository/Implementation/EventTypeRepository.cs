using MiniProjectMvc.Data;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MiniProjectMvc.Repository.Implementation
{
    public class EventTypeRepository : GenericRepository<EventType>, IEventTypeRepository
    {
        private readonly MiniProjectDb _context; 
        public EventTypeRepository(MiniProjectDb context) : base(context)
        {
            _context = context; 
        }

        public async Task<EventType> GetEventTypeByNameAsync(string name)
        {
            return await _context.EventTypes
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(et => et.Name == name && !et.IsDeleted); 
        }

    }
}
