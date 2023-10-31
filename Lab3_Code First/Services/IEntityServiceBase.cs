using DataAccess.Repositories;

namespace Lab3_Code_First.Services
{
    public interface IEntityServiceBase<TKey, TEntity>
        where TEntity : class, IKeyedEntity<TKey>, new()
        where TKey : IEquatable<TKey>
    {
        Task<TEntity> Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<TEntity> Create(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(TKey id);
    }
}
