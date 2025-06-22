using MiniProjectMvc.Entities;
using MiniProjectMvc.ViewModels.Feedback;

namespace MiniProjectMvc.Service.Interfaces
{
    public interface IFeedbackService : IGenericService<FeedbackVM, Feedback>
    {
        Task<FeedbackVM> AddFeedbackAsync(FeedbackCreateVM model);
        Task<IEnumerable<FeedbackVM>> GetFeedbackForEventAsync(int eventId);
        Task<double> GetAverageRatingForEventAsync(int eventId);
        Task<IEnumerable<FeedbackVM>> GetAllFeedbacksWithDetailsAsync();
    }
}
