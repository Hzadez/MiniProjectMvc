using AutoMapper;
using MiniProjectMvc.Entities;
using MiniProjectMvc.Repository.Implementation;
using MiniProjectMvc.Repository.Interface;
using MiniProjectMvc.Services.Interfaces;

namespace MiniProjectMvc.Services.Implemantation
{
    public class GenericService<TEntity> : IGenericServices<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var createdEntity = await _repository.AddAsync(entity);
            return createdEntity;
        }
        
        public async Task<bool> DeleteAsync(int id) 
        {
            var isDeleted = await _repository.DeleteAsync(id);
            return isDeleted;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return entities;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity;
        }

        public async Task<int> SaveChangesAsync() => await _repository.SaveChangesAsync();

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var updatedEntity = await _repository.UpdateAsync(entity);
            if (updatedEntity == null)
            {
                throw new Exception("Entity not found for update.");
            }
            entity.UpdatedAt = DateTime.Now;
            return updatedEntity;
        }
    }
}
