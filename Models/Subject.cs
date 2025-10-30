namespace CollegeManagementSystem.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
