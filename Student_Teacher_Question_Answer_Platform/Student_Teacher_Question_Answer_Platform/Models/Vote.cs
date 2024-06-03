using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Student_Teacher_Question_Answer_Platform.Models
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public int StudentQuestionId { get; set; }

        public int AnswerId { get; set; }

        [ForeignKey("StudentQuestionId")]
        public StudentQuestions StudentQuestion { get; set; }

        [ForeignKey("AnswerId")]
        public Answer Answer { get; set; }

        public bool IsUpvote { get; set; }
    }
}
