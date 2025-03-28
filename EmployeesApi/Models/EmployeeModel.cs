﻿using EmployeesApi.Models.Enums;

namespace EmployeesApi.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Dept Dept { get; set; }
        public bool Status { get; set; }
        public string Turn { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
