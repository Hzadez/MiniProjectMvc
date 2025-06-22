using MiniProjectMvc.Data;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using MiniProjectMvc.Repository.Implementation;

namespace MiniProjectMvc.Repository.Implementation
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        private readonly MiniProjectDb _context;
        public EventRepository(MiniProjectDb context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Event>> GetAllWithDetailsAsync()
        {
            return await _context.Events
                .Include(e=>e.Location)
                .Include(e => e.EventType)
                .Include(e=> e.Organizer)
                .ToListAsync();
        }
    }
}
