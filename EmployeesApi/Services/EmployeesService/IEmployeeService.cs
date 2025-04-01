using EmployeesApi.Models;

namespace EmployeesApi.Services.EmployeesService
{
    public interface IEmployeeService
    {
        Task<ServiceResponse<List<EmployeeModel>>> GetEmployees();
        Task<ServiceResponse<List<EmployeeModel>>> CreateEmployees(EmployeeModel newEmployee);
    }
}
