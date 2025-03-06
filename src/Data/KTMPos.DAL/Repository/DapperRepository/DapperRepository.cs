using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace KTMPos.DAL.Repository.DapperRepository
{
    public class DapperRepository : IDapperRepository
    {
        private readonly string _connectionString;
        private readonly int _commandTimeout = 300;
        public DapperRepository(string connectionString)
        {
            _connectionString = connectionString;

        }

        public async Task ExecuteAsync(string query, Dictionary<string, object> parameter = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using(SqlConnection con=new SqlConnection(_connectionString))
            {
                DynamicParameters param = GetDynamicParameter(parameter);
                await con.ExecuteAsync(query, param,commandTimeout:_commandTimeout,commandType:commandType);
            }
        }


        public async Task<int> ExecuteScalarAsync(string query, Dictionary<string, object> parameter = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                DynamicParameters param= GetDynamicParameter(parameter);
                return await con.ExecuteScalarAsync<int>(query, param, commandTimeout: _commandTimeout, commandType: commandType);
            }
        }

        public async Task<IReadOnlyCollection<T>> QueryAsync<T>(string query, Dictionary<string, object> parameter = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                DynamicParameters param=GetDynamicParameter(parameter);
                return (await con.QueryAsync<T>(query, param, commandTimeout: _commandTimeout, commandType: commandType)).ToList(); 
            }
        }

        public async Task<(object output, IReadOnlyCollection<T>)> QueryAsync<T>(string query, string outputParameter, DynamicParameters parameters, CommandType commandType = CommandType.StoredProcedure)
        {
            using(SqlConnection con= new SqlConnection(_connectionString))
            {
                var result = (await con.QueryAsync<T>(query,parameters,commandTimeout:_commandTimeout,commandType:commandType)).ToList();
                object output = parameters.Get<object>(outputParameter);
                return (output, result);
            }   
        }

        public async Task<T> QueryFirstAsync<T>(string query, Dictionary<string, object> parameter = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using SqlConnection con = new SqlConnection(_connectionString);
            DynamicParameters param = GetDynamicParameter(parameter);
            return await con.QueryFirstOrDefaultAsync<T>(query, param, commandTimeout: _commandTimeout, commandType: commandType);
        }

        public async Task<T> QuerySingleAsync<T>(string query, Dictionary<string, object> parameter = null, CommandType commandType = CommandType.StoredProcedure)
        {
            using SqlConnection con = new SqlConnection(_connectionString);
            DynamicParameters param = GetDynamicParameter(parameter);
            return await con.QuerySingleOrDefaultAsync<T>(query, param, commandTimeout: _commandTimeout, commandType: commandType);
        }
        private DynamicParameters GetDynamicParameter(Dictionary<string, object> parameter)
        { 
            //this method is designed because while passing the data into the database using dapper we need dynamic parameter 
            //rather than theDictionary itself. So this function converts the Dictonary into the Dynamicparameter
            parameter ??= new Dictionary<string, object>();
            if (parameter.Count == 0)
            {
                return null;
            }
            var dynamicParameter=new DynamicParameters(parameter);
            return dynamicParameter;

        }
    }
}
