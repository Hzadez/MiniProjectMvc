using AutoMapper;
using MiniProjectMvc.Data;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;
using MiniProjectMvc.Service.Interfaces;
using MiniProjectMvc.ViewModels.Event;
using Microsoft.EntityFrameworkCore;
using MiniProjectMvc.Data;

namespace MiniProjectMvc.Service.Implementation
{
    public class EventService : GenericService<EventVM, Event>, IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        private readonly MiniProjectDb _context;

        public EventService(IEventRepository eventRepository, IMapper mapper , MiniProjectDb context)
            : base(eventRepository, mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
            _context = context;
        }
            
        public async Task<IEnumerable<EventVM>> GetAllEventsWithDetailsAsync()
        {
            var events = await _eventRepository.GetAllWithDetailsAsync();
            return _mapper.Map<IEnumerable<EventVM>>(events);
        }

        public async Task<EventVM> GetEventByIdWithDetailsAsync(int id)
        {
            var allEventsWithDetails = await _eventRepository.GetAllWithDetailsAsync();
            var eventEntity = allEventsWithDetails.FirstOrDefault(e => e.Id == id);
            return _mapper.Map<EventVM>(eventEntity);
        }

        public async Task<EventVM> CreateEventAsync(EventCreateVM model)
        {
            var entity = _mapper.Map<Event>(model);
            var result = await _eventRepository.AddAsync(entity);
            await _eventRepository.SaveChangesAsync(); 
            return _mapper.Map<EventVM>(result);
        }

        public async Task<EventVM> UpdateEventAsync(EventEditVM model)
        {
            var entity = _mapper.Map<Event>(model);
            var updatedEntity = await _eventRepository.UpdateAsync(entity);
            await _eventRepository.SaveChangesAsync(); // Benzer şekilde
            return _mapper.Map<EventVM>(updatedEntity);
        }
        public async Task<List<Event>> GetCurrentEventsAsync()
        {
            return await _context.Events
                .Where(e => e.Date >= DateTime.Now)
                .OrderBy(e => e.Date)
                .ToListAsync();
        }

    }
}
