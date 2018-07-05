using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly Context Context;
        protected readonly Microsoft.EntityFrameworkCore.DbSet<TEntity> DbSet;

        public GenericRepository(Context context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public async virtual System.Threading.Tasks.Task<bool> DeleteAsync(object id)
        {
            var obj = await GetAsync(id);

            if (obj == null)
                return false;

            Context.Remove(obj);

            await Context.SaveChangesAsync();

            return true;
        }

        public async virtual System.Threading.Tasks.Task<TEntity> GetAsync(object id)
        {
            return await DbSet.FindAsync(id);
        }

        public async virtual System.Threading.Tasks.Task<System.Collections.Generic.List<TEntity>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async virtual System.Threading.Tasks.Task<System.Collections.Generic.List<TEntity>> GetAllAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> where = null, params System.Linq.Expressions.Expression<System.Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> queryable = DbSet;

            foreach (var includeProperty in includeProperties)
                queryable = queryable.Include(includeProperty);

            return await queryable
                .Where(where)
                .ToListAsync();

        }

        public async virtual System.Threading.Tasks.Task<bool> UpdateAsync(object id, TEntity updated)
        {
            try
            {
                Context.Update(updated);
                await Context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public async virtual System.Threading.Tasks.Task<TEntity> InsertAsync(TEntity entity)
        {
            Context.Add(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public virtual bool Delete(object id)
        {
            var obj = Get(id);

            if (obj == null)
                return false;

            Context.Remove(obj);

            Context.SaveChanges();

            return true;
        }

        public virtual TEntity Get(object id)
        {
            return DbSet.Find(id);
        }

        public virtual System.Collections.Generic.List<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual System.Collections.Generic.List<TEntity> GetAll(params System.Linq.Expressions.Expression<System.Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> queryable = DbSet;

            foreach (var includeProperty in includeProperties)
                queryable = queryable.Include(includeProperty);

            return queryable.ToList();

        }

        public virtual bool Update(object id, TEntity updated)
        {
            try
            {
                Context.Update(updated);
                Context.SaveChanges();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }

        public virtual TEntity Insert(TEntity entity)
        {
            Context.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public Task GetAllAsync(long value)
        {
            throw new System.NotImplementedException();
        }
    }
}
