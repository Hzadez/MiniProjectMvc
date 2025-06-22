using MiniProjectMvc.Entities;
using MiniProjectMvc.ViewModels.Participation;

namespace MiniProjectMvc.Service.Interfaces
{
    public interface IParticipationService : IGenericService<ParticipationVM, Participation>
    {
        Task<ParticipationVM> CreateParticipationAsync(int invitationId);
        Task<bool> HasPersonCheckedInForEvent(int personId, int eventId);
        Task<IEnumerable<ParticipationVM>> GetAllParticipationsWithDetailsAsync(); // Yeni
    }
}
