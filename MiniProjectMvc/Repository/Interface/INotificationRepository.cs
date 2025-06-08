using MiniProjectMvc.Entities;

namespace MiniProjectMvc.Repository.Interface
{
    public interface INotificationRepository : IGenericRepository<Notification>
    {
        Task<IEnumerable<Notification>> GetNotificationsWithEventAsync();
    }
}
