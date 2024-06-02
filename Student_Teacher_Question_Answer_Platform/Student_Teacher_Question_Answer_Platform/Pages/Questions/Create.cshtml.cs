using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Teacher_Question_Answer_Platform.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System;
using Student_Teacher_Question_Answer_Platform.Services;

namespace Student_Teacher_Question_Answer_Platform.Pages.Questions
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContest _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateModel(ApplicationDbContest context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public Question Question { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            Question.UserId = user.Id;
            Question.CreatedAt = DateTime.Now;

            _context.Questions.Add(Question);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
