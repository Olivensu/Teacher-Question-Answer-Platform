using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Teacher_Question_Answer_Platform.Models;
using Student_Teacher_Question_Answer_Platform.Services;

namespace Student_Teacher_Question_Answer_Platform.Pages
{
    public class ProductCreateModel : PageModel
    {
        private readonly ApplicationDbContest _context;
        public ProductCreateModel(ApplicationDbContest context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Products { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Products == null || Products == null)
            {
                return Page();
            }

            _context.Products.Add(Products);
            await _context.SaveChangesAsync();

            return RedirectToPage("ProductTable"); // Ensure this is the correct page name
        }
    }
}
