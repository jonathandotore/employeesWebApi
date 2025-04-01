using EmployeesApi.DataContext;
using EmployeesApi.Models;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;


namespace EmployeesApi.Services.EmployeesService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<EmployeeModel>>> GetEmployees()
        {
            ServiceResponse<List<EmployeeModel>> response = new ServiceResponse<List<EmployeeModel>>();

            try
            {
                var employees = _context.Employees.ToList();

                if (employees.Count == 0)
                {
                    response.Data = null;
                    response.Message = "Users not found, please check it and try again!";
                    response.Status = false;
                }

                response.Data = employees;
                response.Message = "Success!";
                response.Status = true;


            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Status = false;

                return response;
            }

            return response;
        }
    }
}
