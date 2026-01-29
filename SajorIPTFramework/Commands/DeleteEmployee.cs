using SajorIPTDomain.Models;
using SajorFramework.Extensions;
using SajorRepository.Interfaces;
using SajorDomain.Commands;

namespace SajorIPTFramework.Commands
{
   
    public class DeleteEmployee : IDeleteEmployee
    {
        private readonly string _connectionName = "DefaultConnection";
        private readonly string _storedProcedureName;
        private readonly IRepository _reposository;

        public DeleteEmployee(IRepository reposository)
        {
            _storedProcedureName = "DeleteEmployee";
            _reposository = reposository;
        }

        public async Task<bool> ExecuteAsync(EmployeeModel model)
        {
            var param = model.ToEmployeeDynamicParameters();
            return await _reposository.SaveDataAsync(
                _connectionName,
                _storedProcedureName,
                param
            );
        }
    }
}
