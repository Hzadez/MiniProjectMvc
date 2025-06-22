using MiniProjectMvc.Areas.Admin.Models;
using MiniProjectMvc.Data;
using MiniProjectMvc.Service.Interfaces;
using MiniProjectMvc.ViewModels.Event;
using Microsoft.EntityFrameworkCore;

namespace MiniProjectMvc.Service.Implementation
{
    public class DashboardService : IDashboardService
    {
        private readonly MiniProjectDb _context;

        public DashboardService(MiniProjectDb context)
        {
            _context = context;
        }

        public async Task<DashboardVM> GetDashboardDataAsync()
        {
            var events = await _context.Events
                .Include(e => e.Location)
                .Include(e => e.EventType)
                .Include(e => e.Organizer)
                .ToListAsync();

            var locationGroups = events
                .GroupBy(e => e.Location.Name)
                .Select(g => new LocationStatVM
                {
                    Name = g.Key,
                    EventCount = g.Count(),
                    Percentage = 100.0 * g.Count() / events.Count
                }).ToList();

            var eventVMs = events.Select(e => new EventVM
            {
                Id = e.Id,
                Title = e.Title,
                Description = e.Description,
                Date = e.Date,
                LocationName = e.Location.Name,
                EventTypeName = e.EventType.Name,
                OrganizerName = e.Organizer.FullName,          
            }).ToList();

            return new DashboardVM
            {
                LocationStats = locationGroups,
                CurrentEvents = eventVMs
            };
        }
    }
}
