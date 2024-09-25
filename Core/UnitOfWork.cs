using Microsoft.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace SportsOrderApp.Core
{
    //public sealed class UnitOfWork : IUnitOfWork
    //{
    //    private IDatabaseContext _dbContext;
    //    private readonly DatabaseContext _dBConnectionContext;
    //    private Dictionary<Type, object> _repos;
    //    private IConfiguration m_config;
    //    private IConnectionManager _connectionManager;
    //    public UnitOfWork(IDatabaseContext contextFactory, DatabaseContext dBConnectionContext, IConfiguration _m_config, IConnectionManager connectionManager)
    //    {
    //        _dbContext = contextFactory;
    //        _dBConnectionContext = dBConnectionContext;
    //        m_config = _m_config;
    //        _connectionManager = connectionManager;
    //    }
    //    public int Commit()
    //    {
    //        return _dbContext.SaveChanges();
    //    }
    //    public async Task<int> CommitAsync()
    //    {
    //        return await _dbContext.SaveChangesAsync(CancellationToken.None);
    //    }
    //    //public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
    //    //{
    //    //    if (_repos == null)
    //    //    {
    //    //        _repos = new Dictionary<Type, object>();
    //    //    }

    //    //    var type = typeof(TEntity);
    //    //    if (!_repos.ContainsKey(type))
    //    //    {
    //    //        _repos[type] = new GenericRepository<TEntity>(_dbContext);
    //    //    }

    //    //    return (IGenericRepository<TEntity>)_repos[type];
    //    //}
    //    //public List<TEntity> SpListRepository<TEntity>(string spName, params object[] parameters) where TEntity : class
    //    //{
    //    //    try
    //    //    {
    //    //        return _dBConnectionContext.Set<TEntity>().FromSqlRaw(spName, parameters).ToList();

    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        return new List<TEntity>();
    //    //    }
    //    //}
    //    public System.Data.SqlClient.SqlDataAdapter getSpSqlDataAdapter(string query)
    //    {
    //        using (System.Data.Entity.DbContext context = new DbContextSP(_connectionManager.GetConnectionStringServerBsed()))
    //        {
    //            context.Database.CommandTimeout = 300;
    //            System.Data.SqlClient.SqlDataAdapter dataAdapter = new System.Data.SqlClient.SqlDataAdapter(query, context.Database.Connection.ConnectionString);
    //            return dataAdapter;
    //        }
    //    }
    //    public List<TEntity> SpListRepository<TEntity>(string query, params object[] parameters) where TEntity : class
    //    {
    //        try
    //        {
    //            using (System.Data.Entity.DbContext context = new DbContextSP(_connectionManager.GetConnectionStringServerBsed()))
    //            {
    //                context.Database.CommandTimeout = 300;
    //                return context.Database.SqlQuery<TEntity>(query, parameters).ToList<TEntity>();
    //            }

    //        }
    //        catch (Exception ex)
    //        {
    //            return new List<TEntity>();
    //        }
    //    }
    //    public List<TEntity> SpListRepositorywebsoft<TEntity>(string query, params object[] parameters1) where TEntity : class
    //    {
    //        try
    //        {
    //            using (System.Data.Entity.DbContext context = new DbContextSP(_connectionManager.GetConnectionStringServerBsedwebsoft()))
    //            {
    //                context.Database.CommandTimeout = 300;
    //                return context.Database.SqlQuery<TEntity>(query, parameters1).ToList<TEntity>();
    //            }

    //        }
    //        catch (Exception ex)
    //        {
    //            return new List<TEntity>();
    //        }
    //    }
    //    public List<TEntity> SpListRepositoryWithConnectionString<TEntity>(string connectionString, string query, params object[] parameters) where TEntity : class
    //    {
    //        try
    //        {
    //            using (System.Data.Entity.DbContext context = new DbContextSP(m_config.GetConnectionString(connectionString)))
    //            {
    //                context.Database.CommandTimeout = 300;
    //                return context.Database.SqlQuery<TEntity>(query, parameters).ToList<TEntity>();
    //            }

    //        }
    //        catch (Exception ex)
    //        {
    //            throw ex;
    //        }
    //    }

    //    //public TEntity SpSingleRepository<TEntity>(string spName, params object[] parameters) where TEntity : class
    //    //{
    //    //    try
    //    //    {
    //    //        return _dBConnectionContext.Set<TEntity>().FromSqlRaw(spName, parameters).FirstOrDefault();
    //    //    }
    //    //    catch
    //    //    {
    //    //        return null;
    //    //    }
    //    //}
    //    public TEntity SpSingleRepository<TEntity>(string query, params object[] parameters) where TEntity : class
    //    {
    //        try
    //        {
    //            using (System.Data.Entity.DbContext context = new DbContextSP(_connectionManager.GetConnectionStringServerBsed()))
    //            {
    //                context.Database.CommandTimeout = 300;
    //                return context.Database.SqlQuery<TEntity>(query, parameters).FirstOrDefault<TEntity>();
    //            }

    //        }
    //        catch (Exception exp)
    //        {
    //            throw;
    //        }
    //    }
    //    //public TEntity SpSingleRepositoryUsingDapper<TEntity>(string procedureName, DynamicParameters param = null) where TEntity : class
    //    //{
    //    //    try
    //    //    {
    //    //        using (SqlConnection sqlCon = new SqlConnection(_connectionManager.GetConnectionStringServerBsed()))
    //    //        {
    //    //            return sqlCon.QueryFirstOrDefault<TEntity>(procedureName, param, commandType: System.Data.CommandType.StoredProcedure);
    //    //        }

    //    //    }
    //    //    catch (Exception exp)
    //    //    {
    //    //        throw;
    //    //    }
    //    //}
    //    //public void ExecuteCommand(string query, params object[] parameters)
    //    //{
    //    //    try
    //    //    {
    //    //        using (System.Data.Entity.DbContext context = new DbContextSP(_connectionManager.GetConnectionStringServerBsed()))
    //    //        {
    //    //            context.Database.CommandTimeout = 300;
    //    //            context.Database.ExecuteSqlCommand(query, parameters);
    //    //        }

    //    //    }
    //    //    catch (Exception)
    //    //    {

    //    //    }
    //    //}
    //    //public void Dispose()
    //    //{
    //    //    Dispose(true);
    //    //    GC.SuppressFinalize(this);
    //    //}
    //    //private void Dispose(bool disposing)
    //    //{
    //    //    if (disposing)
    //    //    {
    //    //        if (_dbContext != null)
    //    //        {
    //    //            _dbContext.Dispose();
    //    //            _dbContext = null;
    //    //        }
    //    //    }
    //    //}

    //    ////where to add these below methods.
    //    //public long getMaximumIdForPatientAndAppointment(string tableName, string columnName, string practiceCode)
    //    //{
    //    //    var tableNameParam = new SqlParameter("@TableName", SqlDbType.VarChar) { Value = tableName };
    //    //    var columnNameParam = new SqlParameter("@colName", SqlDbType.VarChar) { Value = columnName };
    //    //    var practiceCodeParam = new SqlParameter("@Practice_code", SqlDbType.VarChar) { Value = practiceCode };
    //    //    var maxColumn = SpSingleRepository<PatAppMaxColumnID>("Web_Proc_GetMaxID @TableName,@colName,@Practice_code", tableNameParam, columnNameParam, practiceCodeParam);
    //    //    return Convert.ToInt64(maxColumn.MaxColumnID);
    //    //}
    //    //public long getMaximumId(string columnName)
    //    //{

    //    //    var columnNamePar = new SqlParameter("@Col_Name", SqlDbType.VarChar) { Value = columnName };
    //    //    var maxColumn = SpSingleRepository<Web_GetMaxColumnID>("Web_GetMaxColumnID @Col_Name", columnNamePar);
    //    //    if (maxColumn == null || maxColumn.MaxID == null)
    //    //    {
    //    //        InsertMaxColumn(columnName);
    //    //        var columnNamePar2 = new SqlParameter("@Col_Name", SqlDbType.VarChar) { Value = columnName };
    //    //        maxColumn = SpSingleRepository<Web_GetMaxColumnID>("Web_GetMaxColumnID @Col_Name", columnNamePar2);
    //    //    }
    //    //    return Convert.ToInt64(maxColumn.MaxID);
    //    //}
    //    //private void InsertMaxColumn(string columnName)
    //    //{
    //    //    using (var scope = new TransactionScope())
    //    //    {
    //    //        var maintenanceCounter = new Maintenance_Counter
    //    //        {
    //    //            Col_Name = columnName,
    //    //            Col_Counter = 100,
    //    //            SUPPORT_CALL_ID = 0,
    //    //            SUPPORT_TRAINING_ID = 0
    //    //        };
    //    //        GetRepository<Maintenance_Counter>().Add(maintenanceCounter);
    //    //        Commit();
    //    //        scope.Complete();
    //    //    }
    //    //}


    //    //public IList<TEntity> SpListRepositoryUsingDapper<TEntity>(string procedureName, DynamicParameters parameters = null) where TEntity : class
    //    //{
    //    //    try
    //    //    {
    //    //        using (SqlConnection sqlCon = new SqlConnection(_connectionManager.GetConnectionStringServerBsed()))
    //    //        {
    //    //            return sqlCon.Query<TEntity>(procedureName, parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
    //    //        }
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        return new List<TEntity>();
    //    //    }
    //    //}
    //    //public async Task<IEnumerable<TEntity>> SpListRepositoryUsingDapperAsync<TEntity>(string procedureName, DynamicParameters parameters = null) where TEntity : class
    //    //{
    //    //    try
    //    //    {
    //    //        using (SqlConnection sqlCon = new SqlConnection(_connectionManager.GetConnectionStringServerBsed()))
    //    //        {
    //    //            return await sqlCon.QueryAsync<TEntity>(procedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);
    //    //        }
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        return new List<TEntity>();
    //    //    }
    //    //}
    //    ////public async Task<TEntity> SpSingleRepositoryUsingDapperAsync<TEntity>(string procedureName, DynamicParameters parameters = null) where TEntity : class
    //    //{
    //    //    try
    //    //    {
    //    //        using (SqlConnection sqlCon = new SqlConnection(_connectionManager.GetConnectionStringServerBsed()))
    //    //        {
    //    //            // sqlCon.CommandTimeout = 300;
    //    //            return await sqlCon.QueryFirstOrDefaultAsync<TEntity>(procedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);
    //    //        }

    //    //    }
    //    //    catch (Exception exp)
    //    //    {
    //    //        throw;
    //    //    }
    //    //}
    //    //public List<TEntity> SpListRepositoryUsingDapperList<TEntity>(string spName, DynamicParameters parameters = null) where TEntity : class
    //    //{
    //    //    try
    //    //    {
    //    //        using (SqlConnection sqlCon = new SqlConnection(_connectionManager.GetConnectionStringServerBsed()))
    //    //        {
    //    //            return sqlCon.Query<TEntity>(spName, parameters, commandType: System.Data.CommandType.StoredProcedure).ToList<TEntity>();
    //    //        }
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        return new List<TEntity>();
    //    //    }
    //    //}
    //    //public TEntity SpSingleRepositoryWithConnectionString<TEntity>(string connectionString, string query, params object[] parameters) where TEntity : class
    //    //{
    //    //    try
    //    //    {
    //    //        using (System.Data.Entity.DbContext context = new DbContextSP(m_config.GetConnectionString(connectionString)))
    //    //        {
    //    //            context.Database.CommandTimeout = 300;
    //    //            return context.Database.SqlQuery<TEntity>(query, parameters).FirstOrDefault<TEntity>();
    //    //        }

    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        throw ex;
    //    //    }
    //    //}
    //    //public TEntity SpSingleRepositoryUsingDapperWithConnectionString<TEntity>(string connectionString, string procedureName, DynamicParameters parameters = null) where TEntity : class
    //    //{
    //    //    try
    //    //    {
    //    //        using (SqlConnection sqlCon = new SqlConnection(m_config.GetConnectionString(connectionString)))
    //    //        {
    //    //            // sqlCon.CommandTimeout = 300;
    //    //            return sqlCon.QueryFirstOrDefault<TEntity>(procedureName, parameters, commandType: System.Data.CommandType.StoredProcedure);
    //    //        }

    //    //    }
    //    //    catch (Exception exp)
    //    //    {
    //    //        throw;
    //    //    }
    //    //}
    //    //public long getMaximumIdForHCFAImages()
    //    //{
    //    //    return SpSingleRepository("Af_PROC_GET_MAX_HCFAIMAGES_ID");
    //    //}
    //    //public long SpSingleRepository(string query)
    //    //{
    //    //    try
    //    //    {
    //    //        using (System.Data.Entity.DbContext context = new DbContextSP(_connectionManager.GetConnectionStringServerBsed()))
    //    //        {
    //    //            context.Database.CommandTimeout = 300;
    //    //            return context.Database.SqlQuery<long>(query).FirstOrDefault<long>();
    //    //        }

    //    //    }
    //    //    catch (Exception exp)
    //    //    {
    //    //        throw;
    //    //    }
    //    //}
    //}
}
