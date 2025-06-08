using MiniProjectMvc.Repository.Implementation;
using MiniProjectMvc.Repository.Interface;

namespace MiniProjectMvc.Extentions
{
    public static class CustomRepositoryRegistration
    {
        public static void AddCustomRepositories(this IServiceCollection services)
        {
            services.AddScoped<IOrganizerRepository, OrganizerRepository>();
            services.AddScoped<IEventTypeRepository, EventTypeRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IFeedbackRepository, FeedbackRepository>();
            services.AddScoped<IInvitationRepository, InvitationRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
        }
    }
}
