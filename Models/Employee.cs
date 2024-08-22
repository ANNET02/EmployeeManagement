﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Position { get; set; }

        public string? Department { get; set; }
        public decimal Salary { get; set; }
    }
}
