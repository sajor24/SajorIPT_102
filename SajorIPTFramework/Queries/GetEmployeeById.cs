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
   
    public class GetEmployeeById : IGetEmployeeById
    {
        private readonly string _connectionName = "DefaultConnection";
        private readonly string _storeProcedureName;
        private readonly IRepository _repository;

        public GetEmployeeById(IRepository repository)
        {
            _storeProcedureName = "ReadEmployee";
            _repository = repository;
        }

        public async Task<EmployeeModel?> ExecuteAsync(int employeeId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("EmployeeId", employeeId);
            var data = await _repository.GetDataAsync<EmployeeModel>(_connectionName, _storeProcedureName, parameters);
            return data.FirstOrDefault();
        }
    }
}