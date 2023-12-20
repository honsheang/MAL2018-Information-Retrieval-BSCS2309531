using Microsoft.EntityFrameworkCore;
using ProfileService.Model;

namespace TrailApp.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext()
        {

        }
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Trail> Trail { get; set; }
        public DbSet<Activity> Activity { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users", schema: "CW2");
            modelBuilder.Entity<Profile>().ToTable("Profile", schema: "CW2");
            modelBuilder.Entity<Trail>().ToTable("Trail", schema: "CW2");
            modelBuilder.Entity<Activity>().ToTable("Activity", schema: "CW2");
        }

    }
}
