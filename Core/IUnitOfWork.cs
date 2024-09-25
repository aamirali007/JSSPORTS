using Microsoft.Data.SqlClient;

namespace SportsOrderApp.Core
{
    public interface IUnitOfWork
    {
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        int Commit();
        /// <returns>The number of objects in an Added, Modified, or Deleted state asynchronously</returns>
        Task<int> CommitAsync();
        /// <returns>Repository</returns>
        //IGenericRepository<TEntity> GetRepository<TEntity>()
           // where TEntity : class;
        List<TEntity> SpListRepository<TEntity>(string spName, params object[] parameters) where TEntity : class;
        List<TEntity> SpListRepositorywebsoft<TEntity>(string spName, params object[] parameters) where TEntity : class;
        SqlDataAdapter getSpSqlDataAdapter(string query);
        TEntity SpSingleRepository<TEntity>(string spName, params object[] parameters) where TEntity : class;
        List<TEntity> SpListRepositoryWithConnectionString<TEntity>(string connectionString, string query, params object[] parameters) where TEntity : class;
        long getMaximumIdForPatientAndAppointment(string tableName, string columnName, string practiceCode);
        long getMaximumId(string columnName);
        void ExecuteCommand(string query, params object[] parameters);


        //IList<TEntity> SpListRepositoryUsingDapper<TEntity>(string spName, DynamicParameters parameters = null) where TEntity : class;
        //List<TEntity> SpListRepositoryUsingDapperList<TEntity>(string spName, DynamicParameters parameters = null) where TEntity : class;
        //Task<IEnumerable<TEntity>> SpListRepositoryUsingDapperAsync<TEntity>(string spName, DynamicParameters parameters = null) where TEntity : class;
        //TEntity SpSingleRepositoryUsingDapper<TEntity>(string spName, DynamicParameters parameters = null) where TEntity : class;
        //Task<TEntity> SpSingleRepositoryUsingDapperAsync<TEntity>(string spName, DynamicParameters parameters = null) where TEntity : class;
        //TEntity SpSingleRepositoryWithConnectionString<TEntity>(string spName, string query, params object[] parameters) where TEntity : class;
        //TEntity SpSingleRepositoryUsingDapperWithConnectionString<TEntity>(string connectionString, string procedureName, DynamicParameters parameters = null) where TEntity : class;
        long getMaximumIdForHCFAImages();
    }
}
