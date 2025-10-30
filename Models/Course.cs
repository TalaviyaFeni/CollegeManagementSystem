using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeManagementSystem.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        public string CourseName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department name is required")]
        public string DepartmentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Credits are required")]
        [Range(1, 10, ErrorMessage = "Credits must be between 1 and 10")]
        public int Credits { get; set; }

        // 👇 Add this new relationship
        [ForeignKey("Faculty")]
        public int? FacultyId { get; set; }

        public Faculty? Faculty { get; set; }
    }
}
