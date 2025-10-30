using CollegeManagementSystem.Models;
using System;
using System.Linq;

namespace CollegeManagementSystem.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // ✅ If Departments already exist, skip seeding
            if (context.Departments.Any())
                return;

            // 🏫 Seed Departments
            var departments = new Department[]
            {
                new Department { DepartmentName = "Computer Science", Description = "CS Department" },
                new Department { DepartmentName = "Mathematics", Description = "Math Department" }
            };
            context.Departments.AddRange(departments);
            context.SaveChanges();

            // 👩‍🏫 Seed Faculties (updated to match new Faculty model)
            var faculties = new Faculty[]
            {
                new Faculty
                {
                    Name = "Dr. A",
                    Email = "a@example.com",
                    DepartmentName = "Computer Science",
                    Designation = "Professor",
                    DateOfJoining = DateTime.Now
                },
                new Faculty
                {
                    Name = "Dr. B",
                    Email = "b@example.com",
                    DepartmentName = "Mathematics",
                    Designation = "Lecturer",
                    DateOfJoining = DateTime.Now
                }
            };

            context.Faculties.AddRange(faculties);
            context.SaveChanges();
        }
    }
}
