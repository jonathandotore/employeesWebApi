using EmployeesApi.Models;
using EmployeesApi.Services.EmployeesService;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<EmployeeModel>>>> GetEmployees()
        {
            var employees = await _employeeService.GetEmployees();

            if (employees == null)
                return NotFound(); 

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<EmployeeModel>>> GetEmployeeById(int id)
        {
            if (id <= 0) return BadRequest();

            var employee = await _employeeService.GetEmployeeById(id);

            if (employee == null || employee.Data == null) return NotFound();

            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<EmployeeModel>>>> CreateEmployee(EmployeeModel newEmployee)
        {
            var emplyoees = await _employeeService.CreateEmployee(newEmployee);

            return Ok(emplyoees);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<EmployeeModel>>> UpdateEmployee(EmployeeModel employee)
        {
            var updateEmployee = await _employeeService.UpdateEmployee(employee);

            return Ok(employee);
        }

        [HttpPut("disableEmployee/{id}")]
        public async Task<ActionResult<ServiceResponse<EmployeeModel>>> DisableEmployee(int id)
        {
            if (id <= 0) return BadRequest();

            var employee = await _employeeService.DisableEmployee(id);

            if (employee == null || employee.Data == null) return NotFound();

            return Ok(employee);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<EmployeeModel>>> DeleteEmployee(int id)
        {
            if (id <= 0) return BadRequest();

            var employee = await _employeeService.DeleteEmployee(id);

            return Ok();
        }
    }
}
