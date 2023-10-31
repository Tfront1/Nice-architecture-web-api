using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EntityRepositoryBase<TKey, TEntity> : IEntityRepositoryBase<TKey, TEntity>
        where TEntity : class, IKeyedEntity<TKey>, new()
        where TKey : IEquatable<TKey>
    {
        protected readonly SkiResContext dbContext;
        protected readonly DbSet<TEntity> dbSet;

        public EntityRepositoryBase(SkiResContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = this.dbContext.Set<TEntity>();
        }

        public virtual async Task<TEntity> Create(TEntity entity)
        {
            await dbSet.AddAsync(entity).ConfigureAwait(false);
            await dbContext.SaveChangesAsync().ConfigureAwait(false);

            return await Task.FromResult(entity).ConfigureAwait(false);
        }

        public virtual async Task Delete(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Deleted;

            await dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await dbSet.ToListAsync().ConfigureAwait(false);
        }

        public virtual async Task<TEntity> GetById(TKey id) => await dbSet.FirstOrDefaultAsync(x => x.Id.Equals(id));

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;

            await dbContext.SaveChangesAsync().ConfigureAwait(false);

            return entity;
        }
    }
}
