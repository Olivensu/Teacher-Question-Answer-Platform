using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Teacher_Question_Answer_Platform.Models;
using Student_Teacher_Question_Answer_Platform.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Teacher_Question_Answer_Platform.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContest _context;

        public IndexModel(ApplicationDbContest context)
        {
            _context = context;
        }

        public IList<Question> Questions { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1;

        public int TotalPages { get; set; }

        public async Task OnGetAsync()
        {
            int pageSize = 5;
            var questionsQuery = _context.Questions.Include(q => q.User).OrderByDescending(q => q.CreatedAt);
            int totalQuestions = await questionsQuery.CountAsync();
            TotalPages = (int)Math.Ceiling(totalQuestions / (double)pageSize);

            Questions = await questionsQuery
                .Skip((PageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }
}
