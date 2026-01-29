using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SajorIPTDomain.Models;
using SajorRepository.Interfaces;
using SajorDomain.Queries;
namespace SajorIPTFramework.Queries
{
    
    public class GetAllEmployees : IGetAllEmployees
    {
        private readonly string _connectionName = "DefaultConnection";
        private readonly string _storeProcedureName;
        private readonly IRepository _repository;

        public GetAllEmployees(IRepository repository)
        {
            _storeProcedureName = "GetAllEmployees";
            _repository = repository;
        }

        public async Task<IEnumerable<EmployeeModel>> ExecuteAsync()
        {
            var data = await _repository.GetDataAsync<EmployeeModel>(_connectionName, _storeProcedureName);
            return data;
        }
    }
}