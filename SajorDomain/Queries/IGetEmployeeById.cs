using SajorIPTDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SajorDomain.Queries
{
    public interface IGetEmployeeById
    {
        Task<EmployeeModel?> ExecuteAsync(int employeeId);
    }
}
