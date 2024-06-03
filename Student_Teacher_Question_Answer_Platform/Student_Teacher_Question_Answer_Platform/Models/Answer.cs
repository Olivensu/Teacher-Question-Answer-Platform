using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Teacher_Question_Answer_Platform.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public string UserName { get; set; }

        public int StudentQuestionId { get; set; }

        [ForeignKey("StudentQuestionId")]
        public StudentQuestions StudentQuestion { get; set; }
    }
}
