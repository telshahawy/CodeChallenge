using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeChallenge.Shared.Dtos;

namespace CodeChallenge.Shared.Interfaces
{
    public interface IEmployeeService
    {
        int AddEmployee(EmployeeDto employee);
        List<EmployeeDto> GetEmployees();
    }
}
