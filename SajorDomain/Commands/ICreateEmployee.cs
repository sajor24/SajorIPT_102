using SajorIPTDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SajorDomain.Commands
{
    public interface ICreateEmployee
    {
        Task<bool> ExecuteAsync(EmployeeModel model);
    }
}
