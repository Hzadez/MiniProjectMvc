using AutoMapper;
using MiniProjectMvc.Entities;
using MiniProjectMvc.ViewModels.Event;
using MiniProjectMvc.ViewModels.EventType;
using MiniProjectMvc.ViewModels.Feedback;
using MiniProjectMvc.ViewModels.Invitation;
using MiniProjectMvc.ViewModels.Location;
using MiniProjectMvc.ViewModels.Notification;
using MiniProjectMvc.ViewModels.Organizer;
using MiniProjectMvc.ViewModels.Participation;
using MiniProjectMvc.ViewModels.Person;

namespace MiniProjectMvc.Customprofile
{
    public class CustomProfile: Profile
    {
        public CustomProfile()
        {
            CreateMap<EventVM, Event>().ReverseMap();
            CreateMap<EventCreateVM, Event>().ReverseMap();
            CreateMap<EventEditVM, Event>().ReverseMap();
            CreateMap<EventTypeVM, EventType>().ReverseMap();
            CreateMap<EventTypeCreateVM, EventType>().ReverseMap();
            CreateMap<EventTypeCreateVM, EventTypeVM>();
            CreateMap<EventTypeVM, EventTypeEditVM>();
            CreateMap<EventTypeEditVM, EventType>().ReverseMap();
            CreateMap<FeedbackVM, Feedback>().ReverseMap();
            CreateMap<FeedbackCreateVM, Feedback>().ReverseMap();
            CreateMap<InvitationVM, Invitation>().ReverseMap();
            CreateMap<InvitationCreateVM, Invitation>().ReverseMap();
            CreateMap<LocationVM, Location>().ReverseMap();
            CreateMap<LocationCreateVM, Location>().ReverseMap();
            CreateMap<LocationEditVM, Location>().ReverseMap();
            CreateMap<NotificationVM, Notification>().ReverseMap();
            CreateMap<NotificationCreateVM, Notification>().ReverseMap();
            CreateMap<OrganizerVM, Organizer>().ReverseMap();
            CreateMap<OrganizerCreateVM, Organizer>().ReverseMap();
            CreateMap<OrganizerEditVM, Organizer>().ReverseMap();
            CreateMap<ParticipationVM, Participation>().ReverseMap();
            CreateMap<ParticipationCreateVM, Participation>().ReverseMap();
            CreateMap<PersonVM, Person>().ReverseMap();
            CreateMap<PersonCreateVM, Person>().ReverseMap();
            CreateMap<PersonEditVM, Person>().ReverseMap();

        }
    }
}
