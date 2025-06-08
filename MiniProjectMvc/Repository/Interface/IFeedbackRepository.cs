using MiniProjectMvc.Entities;

namespace MiniProjectMvc.Repository.Interface
{
    public interface IFeedbackRepository : IGenericRepository<Feedback>
    {
        Task<IEnumerable<Feedback>> GetFeedbacksWithDetailsAsync();
    }
}
