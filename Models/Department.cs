using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string DepartmentName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // Navigation
        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Faculty> Faculties { get; set; } = new List<Faculty>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
