using System.Data;
using System.Linq.Expressions;

namespace SportsOrderApp.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IQueryable<T> GetDbSet();
        Task<IEnumerable<T>> GetAllAsync();
        T GetSingle(Expression<Func<T, bool>> predictate);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        IQueryable<T> FindByQueryable(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate);
        DataTable ExecuteQuery(string query, params KeyValuePair<string, object>[] parameters);
        bool Exists(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Commit();
    }
}
