using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Teacher_Question_Answer_Platform.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using Student_Teacher_Question_Answer_Platform.Services;
using Microsoft.AspNetCore.Authorization;

namespace Student_Teacher_Question_Answer_Platform.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContest _context;

        public IndexModel(ApplicationDbContest context)
        {
            _context = context;
        }

        public IPagedList<StudentQuestions> StudentQuestions { get; set; }
        public int TotalQuestions { get; set; }
        public string ViewMode { get; set; } = "all";

        public async Task<IActionResult> OnGetAsync(int? pageNumber, string viewMode)
        {
            int pageSize = 5;
            int pageIndex = pageNumber ?? 1;

            ViewMode = viewMode ?? "all";

            IQueryable<StudentQuestions> query = _context.StudentQuestions
                .OrderByDescending(q => q.CreatedAt);

            if (ViewMode == "unanswered")
            {
                query = query.Where(q => !_context.Answers.Any(a => a.StudentQuestionId == q.Id));
            }

            var questionsWithAnswersCount = await query
                .Select(q => new
                {
                    Question = q,
                    AnswersCount = _context.Answers.Count(a => a.StudentQuestionId == q.Id),
                    q.VoteCount
                })
                .ToListAsync();

            // Create a new list of StudentQuestions to include AnswersCount and VoteCount
            var pagedQuestions = questionsWithAnswersCount
                .Select(q => {
                    q.Question.AnswersCount = q.AnswersCount;
                    q.Question.VoteCount = q.VoteCount;
                    return q.Question;
                })
                .ToPagedList(pageIndex, pageSize);

            StudentQuestions = pagedQuestions;
            TotalQuestions = await _context.StudentQuestions.CountAsync();

            return Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var question = await _context.StudentQuestions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }

            _context.StudentQuestions.Remove(question);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}
