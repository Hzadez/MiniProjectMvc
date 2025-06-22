using MiniProjectMvc.Entities;

namespace MiniProjectMvc.Repository.Interface
{
    public interface IOrganizerRepository : IGenericRepository<Organizer>
    {
        Task<Organizer> GetOrganizerByEmailAsync(string email);
    }
}
