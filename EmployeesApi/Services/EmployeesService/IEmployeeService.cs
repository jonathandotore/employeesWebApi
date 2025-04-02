using EmployeesApi.Models;

namespace EmployeesApi.Services.EmployeesService
{
    public interface IEmployeeService
    {
        Task<ServiceResponse<List<EmployeeModel>>> GetEmployees();
        Task<ServiceResponse<EmployeeModel>> GetEmployeeById(int id);
        Task<ServiceResponse<List<EmployeeModel>>> CreateEmployees(EmployeeModel newEmployee);
        Task<ServiceResponse<EmployeeModel>> UpdateEmployees(EmployeeModel employee);
        Task<ServiceResponse<EmployeeModel>> DeleteEmployees(int id);

    }
}
