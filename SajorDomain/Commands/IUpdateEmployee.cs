using SajorIPTDomain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SajorDomain.Commands
{
    public interface IUpdateEmployee
    {
        Task<bool> ExecuteAsync(EmployeeModel model);

    }
}
