using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        System.Threading.Tasks.Task<System.Collections.Generic.List<TEntity>> GetAllAsync();
        System.Threading.Tasks.Task<System.Collections.Generic.List<TEntity>> GetAllAsync(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> where, params System.Linq.Expressions.Expression<System.Func<TEntity, object>>[] includeProperties);
        System.Threading.Tasks.Task<TEntity> GetAsync(object id);
        System.Threading.Tasks.Task<TEntity> InsertAsync(TEntity entity);
        System.Threading.Tasks.Task<bool> UpdateAsync(object id, TEntity updated);
        System.Threading.Tasks.Task<bool> DeleteAsync(object id);

        System.Collections.Generic.List<TEntity> GetAll();
        System.Collections.Generic.List<TEntity> GetAll(params System.Linq.Expressions.Expression<System.Func<TEntity, object>>[] includeProperties);
        TEntity Get(object id);
        TEntity Insert(TEntity entity);
        Task GetAllAsync(long value);
        bool Update(object id, TEntity updated);
        bool Delete(object id);
    }
}
