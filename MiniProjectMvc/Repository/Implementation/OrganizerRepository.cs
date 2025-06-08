using MiniProjectMvc.Data;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;

namespace MiniProjectMvc.Repository.Implementation
{
    public class OrganizerRepository : GenericRepository<Organizer>, IOrganizerRepository
    {
        public OrganizerRepository(MiniProjectDb context) : base(context) { }
    }
}
