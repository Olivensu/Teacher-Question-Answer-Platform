using Microsoft.AspNetCore.Identity;

namespace Student_Teacher_Question_Answer_Platform.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public string Address { get; set; } = "";

        public string Number { get; set; } = "";

        public string Role { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
