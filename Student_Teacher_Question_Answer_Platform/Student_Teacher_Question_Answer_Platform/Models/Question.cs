using System;
using System.ComponentModel.DataAnnotations;

namespace Student_Teacher_Question_Answer_Platform.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ApplicationUser User { get; set; }
    }
}
