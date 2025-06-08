using MiniProjectMvc.Data;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;

namespace MiniProjectMvc.Repository.Implementation
{
    public class LocationRepository : GenericRepository<Location>,ILocationRepository
    {
        public LocationRepository(MiniProjectDb context) : base(context) { }
    }
}
