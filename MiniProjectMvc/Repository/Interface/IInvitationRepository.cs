using MiniProjectMvc.Entities;

namespace MiniProjectMvc.Repository.Interface
{
    public interface IInvitationRepository : IGenericRepository<Invitation>
    {
        Task<IEnumerable<Invitation>> GetInvitationsWithEventAndPersonAsync();
    }
}
