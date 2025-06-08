using MiniProjectMvc.Data;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MiniProjectMvc.Repository.Implementation
{
    public class FeedbackRepository : GenericRepository<Feedback>, IFeedbackRepository
    {
        private readonly MiniProjectDb _context;
        public FeedbackRepository(MiniProjectDb context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Feedback>> GetFeedbacksWithDetailsAsync()
        {
            return await _context.Feedbacks
                .Include(f => f.Event)
                .Include(f => f.Person)
                .ToListAsync();
        }
    }
}
