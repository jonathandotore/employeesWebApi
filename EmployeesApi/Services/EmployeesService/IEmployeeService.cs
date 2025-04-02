using EmployeesApi.Models;

namespace EmployeesApi.Services.EmployeesService
{
    public interface IEmployeeService
    {
        Task<ServiceResponse<List<EmployeeModel>>> GetEmployees();
        Task<ServiceResponse<EmployeeModel>> GetEmployeeById(int id);
        Task<ServiceResponse<List<EmployeeModel>>> CreateEmployee(EmployeeModel newEmployee);
        Task<ServiceResponse<EmployeeModel>> UpdateEmployee(EmployeeModel employee);    
        Task<ServiceResponse<EmployeeModel>> DeleteEmployee(int id);
        Task<ServiceResponse<EmployeeModel>> DisableEmployee(int id);
    }
}
