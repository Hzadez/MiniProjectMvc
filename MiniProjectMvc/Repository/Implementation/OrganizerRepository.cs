using MiniProjectMvc.Data;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MiniProjectMvc.Repository.Implementation
{
    public class OrganizerRepository : GenericRepository<Organizer>, IOrganizerRepository
    {
        private readonly MiniProjectDb _context; 
        public OrganizerRepository(MiniProjectDb context) : base(context)
        {
            _context = context; 
        }
        public async Task<Organizer> GetOrganizerByEmailAsync(string email)
        {
            return await _context.Organizers
                                 .AsNoTracking() 
                                 .FirstOrDefaultAsync(o => o.Email == email && !o.IsDeleted); 
        }
    }
}
