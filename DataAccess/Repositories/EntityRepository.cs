using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EntityRepository<TKey, TEntity> : EntityRepositoryBase<TKey, TEntity>, IEntityRepository<TKey, TEntity>
    where TEntity : class, IKeyedEntity<TKey>, new()
    where TKey : IEquatable<TKey>
    {
        public EntityRepository(SkiResContext dbContext)
            : base(dbContext)
        {
        } 
    }
}
