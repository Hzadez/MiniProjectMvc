using MiniProjectMvc.Entities;
using MiniProjectMvc.ViewModels.Organizer;

namespace MiniProjectMvc.Service.Interfaces
{
    public interface IOrganizerService : IGenericService<OrganizerVM, Organizer>
    {
        Task CreateAsync(OrganizerCreateVM model);
        Task<OrganizerVM> GetOrganizerByEmailAsync(string email);
        Task Update(OrganizerEditVM model);
    }
}
