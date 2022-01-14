using CodeChallenge.Shared.Dtos;
using CodeChallenge.Shared.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallenge.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }
        [HttpGet]
        public IEnumerable<EmployeeDto> Get()
        {
            return _employeeService.GetEmployees();
        }

        [HttpPost]
        public int Add(EmployeeDto dto)
        {
            return _employeeService.AddEmployee(dto);
        }
    }
}
