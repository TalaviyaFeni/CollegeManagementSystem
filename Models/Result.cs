using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models
{
    public class Result
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Student name is required")]
        public string StudentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; } = string.Empty;

        [Required(ErrorMessage = "Marks are required")]
        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100")]
        public int Marks { get; set; }

        [Required(ErrorMessage = "Grade is required")]
        public string Grade { get; set; } = string.Empty;
    }
}
