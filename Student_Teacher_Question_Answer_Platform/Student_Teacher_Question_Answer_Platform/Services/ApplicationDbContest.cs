using Student_Teacher_Question_Answer_Platform.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Student_Teacher_Question_Answer_Platform.Services
{
    public class ApplicationDbContest : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContest(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var moderator = new IdentityRole("moderator");
            moderator.NormalizedName = "moderator";

            var student = new IdentityRole("student");
            student.NormalizedName = "student";

            var teacher = new IdentityRole("teacher");
            teacher.NormalizedName = "teacher";

            builder.Entity<IdentityRole>().HasData(moderator, student, teacher);
        }
    }
}
