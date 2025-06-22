using MiniProjectMvc.Entities;

namespace MiniProjectMvc.Repository.Interface
{
    public interface IParticipationRepository : IGenericRepository<Participation>
    {
        Task<Participation> GetParticipationByInvitationIdAsync(int invitationId);
        Task<IEnumerable<Participation>> GetParticipationsWithInvitationDetailsAsync();
    }
}
