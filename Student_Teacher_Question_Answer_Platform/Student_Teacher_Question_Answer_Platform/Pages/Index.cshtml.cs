using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Teacher_Question_Answer_Platform.Models;
using Student_Teacher_Question_Answer_Platform.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Student_Teacher_Question_Answer_Platform.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContest _context;

        public IndexModel(ApplicationDbContest context)
        {
            _context = context;
        }

      

        public IPagedList<StudentQuestions> StudentQuestions { get; set; }

        public async Task<IActionResult> OnGetAsync(int? pageNumber)
        {
            int pageSize = 5;
            int pageIndex = pageNumber ?? 1;

            StudentQuestions = await _context.StudentQuestions
                .OrderByDescending(q => q.CreatedAt)
                .ToPagedListAsync(pageIndex, pageSize);

            return Page();
        }
    }
}
