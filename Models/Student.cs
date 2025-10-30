using System;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Student Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Enrollment Number")]
        [Required(ErrorMessage = "Enrollment Number is required")]
        public string EnrollmentNumber { get; set; } = string.Empty;

        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "Department Name is required")]
        public string DepartmentName { get; set; } = string.Empty;

        [Display(Name = "Date of Admission")]
        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; } = DateTime.Now;
    }
}
