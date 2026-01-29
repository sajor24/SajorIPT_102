using System.Data;
using Dapper;
using SajorRepository.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SajorRepository
{
    public class Repository : IRepository
    {
        private readonly IConfiguration _configuration;

        public Repository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<T>> GetDataAsync<T>(string connectionName, string storedProcName, DynamicParameters? parameters = null)
        {
            IEnumerable<T> result;
            var connectionString = _configuration.GetConnectionString(connectionName);
            
            using var connection = new SqlConnection(connectionString);
            
            if (parameters is not null)
                result = await connection.QueryAsync<T>(storedProcName, param: parameters, commandType: CommandType.StoredProcedure);
            else
                result = await connection.QueryAsync<T>(storedProcName, commandType: CommandType.StoredProcedure);
            
            return result;
        }

        public async Task<bool> SaveDataAsync(string connectionName, string storedProcName, DynamicParameters? parameters = null)
        {
            int rowsAffected = 0;
            var connectionString = _configuration.GetConnectionString(connectionName);
            
            using var connection = new SqlConnection(connectionString);
            
            if (parameters is not null)
                rowsAffected = await connection.ExecuteAsync(storedProcName, param: parameters, commandType: CommandType.StoredProcedure);
            else
                rowsAffected = await connection.ExecuteAsync(storedProcName, commandType: CommandType.StoredProcedure);
            
            return rowsAffected > 0;
        }
    }
}
