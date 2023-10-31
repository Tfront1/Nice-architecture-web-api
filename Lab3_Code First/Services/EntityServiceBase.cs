using DataAccess.Repositories;

namespace Lab3_Code_First.Services
{
    public class EntityServiceBase<TKey, TEntity> : IEntityServiceBase<TKey, TEntity>
        where TEntity : class, IKeyedEntity<TKey>, new()
        where TKey : IEquatable<TKey>
    {
        private readonly IEntityRepository<TKey, TEntity> _repository;
        public EntityServiceBase(IEntityRepository<TKey, TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            return await _repository.Create(entity);
        }

        public async Task Delete(TEntity entity)
        {
            await _repository.Delete(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<TEntity> GetById(TKey id)
        {
            return await _repository.GetById(id);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            return await _repository.Update(entity);
        }
    }
}
