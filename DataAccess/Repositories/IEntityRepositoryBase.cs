using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IEntityRepositoryBase<TKey, TEntity>
        where TEntity : class, IKeyedEntity<TKey>, new()
        where TKey : IEquatable<TKey>
    {
        Task<TEntity> Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<TEntity> Create(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(TKey id);
    }
    public interface IEntityRepository<TKey, TEntity> : IEntityRepositoryBase<TKey, TEntity>
        where TEntity : class, IKeyedEntity<TKey>, new()
        where TKey : IEquatable<TKey>
    {
    }
}
