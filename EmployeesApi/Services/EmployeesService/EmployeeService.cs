﻿using EmployeesApi.DataContext;
using EmployeesApi.Models;
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
                var employees = await _context.Employees.ToListAsync();

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
        public async Task<ServiceResponse<EmployeeModel>> GetEmployeeById(int id)
        {
            ServiceResponse<EmployeeModel> response = new ServiceResponse<EmployeeModel>();

            if (id == 0)
            {
                response.Message = "Provided id is invalid";
                response.Status = false;
            }
            
            try
            {
                var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);

                if (employee == null)
                {
                    response.Data = null;
                    response.Message = "User not found, check provided id and try again";
                    response.Status = false;
                }

                response.Data = employee;
                response.Message = "Success!";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Status = false;
            }

            return response;
        }
        public async Task<ServiceResponse<List<EmployeeModel>>> CreateEmployees(EmployeeModel newEmployee)
        {
            ServiceResponse<List<EmployeeModel>> response = new ServiceResponse<List<EmployeeModel>>();

            try
            {
                if (newEmployee == null)
                {
                    response.Message = "Please, check the provided information and try again.";

                    return response;
                }

                await _context.AddAsync(newEmployee);
                var row = await _context.SaveChangesAsync();

                if (row == 0)
                {
                    response.Message = "User was not registered, please call client supp or try again later";

                    return response;
                }

                var employees = await _context.Employees.AsNoTracking().ToListAsync();

                response.Data = employees;
                response.Message = "Employee successfully registered!";
                response.Status = true;

            }
            catch (Exception ex)
            {
                response.Data = null;
                response.Message = ex.Message;
                response.Status = false;
            }

            return response;
        }
        public Task<ServiceResponse<EmployeeModel>> UpdateEmployees(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }
        public Task<ServiceResponse<EmployeeModel>> DeleteEmployees(int id)
        {
            throw new NotImplementedException();
        }
    }
}
