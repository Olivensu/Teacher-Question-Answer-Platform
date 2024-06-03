using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Teacher_Question_Answer_Platform.Models;
using Student_Teacher_Question_Answer_Platform.Services;

namespace Student_Teacher_Question_Answer_Platform.Pages
{
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

            // Set the user information
            // You may want to get the username from the current user session
            // Answer.UserName = User.Identity.Name;
            StudentQuestionId = questionId;
            // Set the current date and time
            Answer.CreatedAt = DateTime.Now;

            // Set the StudentQuestionId
            Answer.StudentQuestionId = StudentQuestionId;

            // Add the answer to the database
            _context.Answers.Add(Answer);
            await _context.SaveChangesAsync();

            // Redirect to the details page of the question
            return RedirectToPage("/QuestionsDetails", new { id = questionId });
        }
    }
}
