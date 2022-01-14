using CodeChallenge.Server.Models;
using CodeChallenge.Shared.Dtos;
using CodeChallenge.Shared.Interfaces;

namespace CodeChallenge.Server.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _dataContext;

        public EmployeeService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int AddEmployee(EmployeeDto dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));
            var employee = new Employee()
            {
                Name = dto.Name,
                CreationDate = DateTime.Now
            };
            _dataContext.Add(employee);
            _dataContext.SaveChanges();

            return employee.Id;
        }

        public List<EmployeeDto> GetEmployees()
        {
            return _dataContext.Employees.Select(c => new EmployeeDto()
            {
                Id = c.Id,
                Name = c.Name,
                CreationDate = c.CreationDate,
            }).ToList();
        }
    }
}
