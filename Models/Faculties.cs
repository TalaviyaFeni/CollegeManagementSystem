using System;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Phone]
        
        public string? Designation { get; set; }

        public string? DepartmentName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfJoining { get; set; }
    }
}
