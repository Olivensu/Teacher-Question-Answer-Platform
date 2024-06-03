using System.ComponentModel.DataAnnotations;

namespace Student_Teacher_Question_Answer_Platform.Models
{
    public class StudentQuestions
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UserName { get; set; }
    }
}
