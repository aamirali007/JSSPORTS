using Microsoft.EntityFrameworkCore;
using SportsOrderApp.Data;
using System.Data;
using System.Linq.Expressions;

namespace SportsOrderApp.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly JSDBContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(JSDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetDbSet()
        {
            return _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().AsEnumerable();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicate);
        }
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }
            return await query.FirstOrDefaultAsync(predicate);
        }
        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).AsEnumerable();
        }
        public IQueryable<T> FindByQueryable(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }
        public async Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }
        public bool Exists(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Any(predicate);
        }
        public void Add(T entity)
        {
            //entity.Id = GetSequenceNo();
            _context.Entry(entity).State = EntityState.Added;
        }
        public void Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }
        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }


        //public T GetClone(T entity)
        //{
        //    //return (T)_context.Entry(entity).CurrentValues.Clone().ToObject();
        //    return ((T)_context.Entry(entity).Entity);

        //}

        //public bool DetectChanges(T entity1, T entity2)
        //{
        //    var properties = typeof(T).GetProperties();
        //    foreach (var pi in properties)
        //    {
        //        object value1 = typeof(T).GetProperty(pi.Name).GetValue(entity1, null);
        //        object value2 = typeof(T).GetProperty(pi.Name).GetValue(entity2, null);

        //        if (value1 != value2 && (value1 == null || !value1.Equals(value2)))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        public DataTable ExecuteQuery(string query, params KeyValuePair<string, object>[] parameters)
        {
            DataTable table = new DataTable();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                foreach (var parameter in parameters)
                {
                   // command.Parameters.Add(new OracleParameter(parameter.Key, parameter.Value));
                }
                //command.Parameters.AddRange(parameters);
                try
                {
                    _context.Database.OpenConnection();
                    using (var reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                }
                finally
                {
                    _context.Database.CloseConnection();
                }
            }
            return table;
        }

        //public DataTable GetData(string Query, params object[] parameters)
        //{
        //    /// string connection = _context.Database.GetDbConnection().ConnectionString.ToString();


        //    var connection = _context.Database.GetDbConnection().ConnectionString;
        //    OracleConnection Con = new OracleConnection(connection);
        //    DataTable dt = new DataTable();
        //    OracleDataAdapter da = new OracleDataAdapter(Query, connection);
        //    da.Fill(dt);
        //    Con.Close();
        //    Con.Dispose();
        //    return dt;
        //}
        //private int GetSequenceNo()
        //{
        //    string sequence = Sequence.GetSequenceString(typeof(T));
        //    using (var command = _context.Database.GetDbConnection().CreateCommand())
        //    {
        //        command.CommandText = String.Format("SELECT {0}.nextval FROM dual", sequence);
        //        command.CommandType = CommandType.Text;
        //        _context.Database.OpenConnection();

        //        using (var reader = command.ExecuteReader())
        //        {
        //            reader.Read();
        //            int newSequence = reader.GetInt32(0);
        //            _context.Database.CloseConnection();
        //            return newSequence;
        //        }
        //    }
        //}

    }
}
