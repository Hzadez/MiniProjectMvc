﻿using AutoMapper;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Interface;
using MiniProjectMvc.Service.Interfaces;
using MiniProjectMvc.ViewModels.Location;

namespace MiniProjectMvc.Service.Implementation
{
    public class LocationService : GenericService<LocationVM, Location>, ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IMapper _mapper;

        public LocationService(ILocationRepository locationRepository, IMapper mapper)
            : base(locationRepository, mapper)
        {
            _locationRepository = locationRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(LocationCreateVM model)
        {
            var entity = _mapper.Map<Location>(model);
            await _locationRepository.AddAsync(entity);
            await _locationRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<LocationVM>> GetLocationsWithCapacityGreaterThan(int capacity)
        {
            var locations = await _locationRepository.GetLocationsByCapacityAsync(capacity);
            return _mapper.Map<IEnumerable<LocationVM>>(locations);
        }

        public async Task Update(LocationEditVM model)
        {
            var entity = _mapper.Map<Location>(model);
            await _locationRepository.UpdateAsync(entity);
            await _locationRepository.SaveChangesAsync();
        }
    }
}
