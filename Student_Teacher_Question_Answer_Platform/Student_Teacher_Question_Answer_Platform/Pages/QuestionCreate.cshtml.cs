using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Teacher_Question_Answer_Platform.Models;
using Student_Teacher_Question_Answer_Platform.Services;
using System.Threading.Tasks;

namespace Student_Teacher_Question_Answer_Platform.Pages
{
    public class QuestionCreateModel : PageModel
    {
        private readonly ApplicationDbContest _context;

        public QuestionCreateModel(ApplicationDbContest context)
        {
            _context = context;
        }

        [BindProperty]
        public StudentQuestions StudentQuestions { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.StudentQuestions == null || StudentQuestions == null)
            {
                return Page();
            }

            _context.StudentQuestions.Add(StudentQuestions);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index"); // Ensure this is the correct page name
        }
    }
}
