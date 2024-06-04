using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Teacher_Question_Answer_Platform.Models;
using Student_Teacher_Question_Answer_Platform.Services;

namespace Student_Teacher_Question_Answer_Platform.Pages
{
    [Authorize(Roles = "teacher")]
    public class AnswerModel : PageModel
    {
        private readonly ApplicationDbContest _context;

        public AnswerModel(ApplicationDbContest context)
        {
            _context = context;
        }

        [BindProperty]
        public Answer Answer { get; set; }

        [BindProperty(SupportsGet = true)]
        public int StudentQuestionId { get; set; }


        public async Task<IActionResult> OnPostAsync(int questionId)
        {

            StudentQuestionId = questionId;
            Answer.CreatedAt = DateTime.Now;

            Answer.StudentQuestionId = StudentQuestionId;

            _context.Answers.Add(Answer);
            await _context.SaveChangesAsync();

            return RedirectToPage("/QuestionsDetails", new { id = questionId });
        }
    }
}
