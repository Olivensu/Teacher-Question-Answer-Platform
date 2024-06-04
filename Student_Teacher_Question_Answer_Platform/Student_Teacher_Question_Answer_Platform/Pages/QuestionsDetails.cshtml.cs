using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Teacher_Question_Answer_Platform.Models;
using Student_Teacher_Question_Answer_Platform.Services;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Student_Teacher_Question_Answer_Platform.Pages
{
    [Authorize]
    public class QuestionsDetailsModel : PageModel
    {
        private readonly ApplicationDbContest _context;

        public QuestionsDetailsModel(ApplicationDbContest context)
        {
            _context = context;
        }

        public StudentQuestions StudentQuestion { get; set; }
        public IList<Answer> Answers { get; set; }
        public int AnswersCount { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            StudentQuestion = await _context.StudentQuestions
                .FirstOrDefaultAsync(m => m.Id == id);

            if (StudentQuestion == null)
            {
                return NotFound();
            }

            Answers = await _context.Answers
                .Where(a => a.StudentQuestionId == id)
                .ToListAsync();

            AnswersCount = Answers.Count;

            return Page();
        }

        public async Task<IActionResult> OnPostVoteQuestionAsync(int questionId, bool isUpvote)
        {
            var question = await _context.StudentQuestions.FindAsync(questionId);
            if (question == null)
            {
                return NotFound();
            }

            if (isUpvote)
            {
                question.VoteCount++;
            }
            else
            {
                question.VoteCount--;
            }

            await _context.SaveChangesAsync();
            return RedirectToPage(new { id = questionId });
        }

        public async Task<IActionResult> OnPostVoteAnswerAsync(int answerId, bool isUpvote)
        {
            var answer = await _context.Answers.FindAsync(answerId);
            if (answer == null)
            {
                return NotFound();
            }

            if (isUpvote)
            {
                answer.VoteCount++;
            }
            else
            {
                answer.VoteCount--;
            }

            await _context.SaveChangesAsync();
            return RedirectToPage(new { id = answer.StudentQuestionId });
        }

        
    }
}
