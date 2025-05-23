﻿using EmployeesApi.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmployeesApi.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public EDept Dept { get; set; }
        public bool Status { get; set; }
        public ETurn Turn { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
