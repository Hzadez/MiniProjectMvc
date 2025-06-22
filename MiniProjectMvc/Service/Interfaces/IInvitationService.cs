using MiniProjectMvc.Entities;
using MiniProjectMvc.Enums;
using MiniProjectMvc.ViewModels.Invitation;

namespace MiniProjectMvc.Service.Interfaces
{
    public interface IInvitationService : IGenericService<InvitationVM, Invitation>
    {
        Task<InvitationVM> CreateInvitationAsync(InvitationCreateVM model);
        Task<bool> UpdateInvitationStatusAsync(int invitationId, InvitationStatus status);
        Task<IEnumerable<InvitationVM>> GetInvitationsForPersonAsync(int personId);
        Task<IEnumerable<InvitationVM>> GetInvitationsForEventAsync(int eventId);
        Task<InvitationVM> GetInvitationWithDetailsByIdAsync(int id, bool asNoTracking = false);
    }
}