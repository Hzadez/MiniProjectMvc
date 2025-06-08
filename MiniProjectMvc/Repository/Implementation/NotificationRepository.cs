using MiniProjectMvc.Data;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace MiniProjectMvc.Repository.Implementation
{
    public class NotificationRepository : GenericRepository<Notification> ,INotificationRepository
    {
        private readonly MiniProjectDb _context;
        public NotificationRepository(MiniProjectDb context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Notification>> GetNotificationsWithEventAsync()
        {
            return await _context.Notifications
                .Include(n => n.Event)
                .ToListAsync();
        }
    }
}
