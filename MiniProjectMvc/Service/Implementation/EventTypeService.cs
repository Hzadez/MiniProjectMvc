using AutoMapper;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;
using MiniProjectMvc.Service.Interfaces;
using MiniProjectMvc.ViewModels.EventType;

namespace MiniProjectMvc.Service.Implementation
{
    public class EventTypeService : GenericService<EventTypeVM, EventType>, IEventTypeService
    {
        private readonly IEventTypeRepository _eventTypeRepository;
        private readonly IMapper _mapper;

        public EventTypeService(IEventTypeRepository eventTypeRepository, IMapper mapper)
            : base(eventTypeRepository, mapper)
        {
            _eventTypeRepository = eventTypeRepository;
            _mapper = mapper;
        }

        public async Task<EventTypeVM> GetEventTypeByNameAsync(string name)
        {
            var eventTypeEntity = await _eventTypeRepository.GetEventTypeByNameAsync(name);
            return _mapper.Map<EventTypeVM>(eventTypeEntity);
        }

        public async Task Update(EventType eventTypeEntity)
        {
            await _eventTypeRepository.UpdateAsync(eventTypeEntity);
            await _eventTypeRepository.SaveChangesAsync();
        }
    }
}
