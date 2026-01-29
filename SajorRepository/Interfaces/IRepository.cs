using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;

namespace SajorRepository.Interfaces
{
    public interface IRepository
    {
        Task<IEnumerable<T>> GetDataAsync<T>(string connectionName, string storedProcName, DynamicParameters? parameters = null);
        Task<bool> SaveDataAsync(string connectionName, string storedProcName, DynamicParameters? parameters = null);
    }
}
