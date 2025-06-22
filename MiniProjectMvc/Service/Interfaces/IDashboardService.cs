using MiniProjectMvc.Areas.Admin.Models;

namespace MiniProjectMvc.Service.Interfaces
{
    public interface IDashboardService
    {
        Task<DashboardVM> GetDashboardDataAsync();
    }
}
