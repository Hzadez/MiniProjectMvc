using AutoMapper;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Enums;
using MiniProjectMvc.Repository.Interface;
using MiniProjectMvc.Service.Interfaces;
using MiniProjectMvc.ViewModels.Invitation;
using Microsoft.EntityFrameworkCore;

namespace MiniProjectMvc.Service.Implementation
{
    public class InvitationService : GenericService<InvitationVM, Invitation>, IInvitationService
    {
        private readonly IInvitationRepository _invitationRepository;
        private readonly IMapper _mapper;

        public InvitationService(IInvitationRepository invitationRepository, IMapper mapper)
            : base(invitationRepository, mapper)
        {
            _invitationRepository = invitationRepository;
            _mapper = mapper;
        }

        public async Task<InvitationVM> CreateInvitationAsync(InvitationCreateVM model)
        {
            var invitation = _mapper.Map<Invitation>(model);
            invitation.SentAt = DateTime.UtcNow;

            var result = await _invitationRepository.AddAsync(invitation);
            await _invitationRepository.SaveChangesAsync();
            return _mapper.Map<InvitationVM>(result);
        }

        public async Task<bool> UpdateInvitationStatusAsync(int invitationId, InvitationStatus status)
        {
            var invitation = await _invitationRepository.GetByIdAsync(invitationId);
            if (invitation == null)
                return false;

    

            await _invitationRepository.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<InvitationVM>> GetInvitationsForPersonAsync(int personId)
        {
            var allInvitations = await _invitationRepository.GetInvitationsWithEventAndPersonAsync();
            var filtered = allInvitations.Where(i => i.PersonId == personId);
            return _mapper.Map<IEnumerable<InvitationVM>>(filtered);
        }

        public async Task<IEnumerable<InvitationVM>> GetInvitationsForEventAsync(int eventId)
        {
            var allInvitations = await _invitationRepository.GetInvitationsWithEventAndPersonAsync();
            var filtered = allInvitations.Where(i => i.EventId == eventId);
            return _mapper.Map<IEnumerable<InvitationVM>>(filtered);
        }

        public async Task<InvitationVM> GetInvitationWithDetailsByIdAsync(int id, bool asNoTracking = false)
        {
            var allInvitations = await _invitationRepository.GetInvitationsWithEventAndPersonAsync();

            var invitation = allInvitations.FirstOrDefault(i => i.Id == id);

            if (invitation == null) return null;

            // AsNoTracking lazımdırsa, burda əlavə metod əlavə etmək olar repository-də

            return _mapper.Map<InvitationVM>(invitation);
        }
    }
}
