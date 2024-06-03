using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Teacher_Question_Answer_Platform.Models;
using Student_Teacher_Question_Answer_Platform.Services;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Student_Teacher_Question_Answer_Platform.Pages
{
    public class QuestionsDetailsModel : PageModel
    {
        private readonly ApplicationDbContest _context;

        public QuestionsDetailsModel(ApplicationDbContest context)
        {
            _context = context;
        }

        public StudentQuestions StudentQuestion { get; set; }
        public IList<Answer> Answers { get; set; }

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

            return Page();
        }
    }
}
