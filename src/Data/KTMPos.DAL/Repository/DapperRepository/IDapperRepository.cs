using Dapper;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace KTMPos.DAL.Repository.DapperRepository
{
    public interface IDapperRepository
    {
        //This method is used to execute a query that retrieves multiple rows from the database. Each row is mapped to an object of type T.
        Task<IReadOnlyCollection<T>>QueryAsync<T>(string query,Dictionary<string,object> parameter=default,CommandType commandType=CommandType.StoredProcedure);
        //This method is used for queries that not only return rows but also have output parameters.
        Task<(object output, IReadOnlyCollection<T>)> QueryAsync<T>(string query, string outputParameter, DynamicParameters parameters, CommandType commandType = CommandType.StoredProcedure);
        //Executes a query that retrieves exactly one row from the database.
        Task<T> QuerySingleAsync<T>(string query, Dictionary<string, object> parameter = default, CommandType commandType = CommandType.StoredProcedure);
        //Retrieves the first row from the query result. This is useful if you expect multiple rows but are only interested in the first
        Task<T> QueryFirstAsync<T>(string query, Dictionary<string, object> parameter = default, CommandType commandType = CommandType.StoredProcedure);
        //Executes a query or stored procedure that does not return rows. Often used for INSERT, UPDATE, or DELETE operations.
        Task ExecuteAsync(string query, Dictionary<string, object> parameter = default, CommandType commandType = CommandType.StoredProcedure);
        //Executes a query or stored procedure and retrieves a single scalar value(e.g., a count or sum).
        Task<int> ExecuteScalarAsync(string query, Dictionary<string, object> parameter = default, CommandType commandType = CommandType.StoredProcedure);


    }
}
