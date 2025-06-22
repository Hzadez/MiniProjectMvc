using MiniProjectMvc.ViewModels.Event;

namespace MiniProjectMvc.Areas.Admin.Models
{
    public class DashboardVM
    {
        public List<LocationStatVM> LocationStats { get; set; }
        public List<EventVM> CurrentEvents { get; set; }
    }
}
