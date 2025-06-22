using MiniProjectMvc.Data;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MiniProjectMvc.Repository.Implementation
{
    public class LocationRepository : GenericRepository<Location>,ILocationRepository
    {
        private readonly MiniProjectDb _context; 
        public LocationRepository(MiniProjectDb context) : base(context)
        {
            _context = context; 
        }

        public async Task<IEnumerable<Location>> GetLocationsByCapacityAsync(int capacity)
        {
            return await _context.Locations
                                 .Where(l => l.Capacity >= capacity && !l.IsDeleted)
                                 .AsNoTracking() 
                                 .ToListAsync();
        }
    }
}
