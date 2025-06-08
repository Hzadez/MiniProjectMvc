using MiniProjectMvc.Data;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MiniProjectMvc.Repository.Implementation
{
    public class InvitationRepository : GenericRepository<Invitation>, IInvitationRepository
    {
        private readonly MiniProjectDb _context;
        public InvitationRepository(MiniProjectDb context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Invitation>> GetInvitationsWithEventAndPersonAsync()
        {
            return await _context.Invitations
                .Include(i => i.Event)
                .Include(i => i.Person)
                .ToListAsync();
        }
    }
}
