using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CollegeManagementSystem.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // Load configuration from appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            // Read connection string from appsettings.json
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Create options builder
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // ✅ Use SQLite (best for macOS)
            optionsBuilder.UseSqlite(connectionString);

            // Return a new instance of your DbContext
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
