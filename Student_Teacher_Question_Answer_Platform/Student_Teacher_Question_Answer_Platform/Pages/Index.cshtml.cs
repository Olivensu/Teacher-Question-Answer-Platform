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

            // Fetch answer count for each question
            var questionsWithAnswersCount = await _context.StudentQuestions
                .Select(q => new
                {
                    Question = q,
                    AnswersCount = _context.Answers.Count(a => a.StudentQuestionId == q.Id)
                })
                .ToListAsync();

            // Map answer count to each question
            foreach (var question in StudentQuestions)
            {
                question.AnswersCount = questionsWithAnswersCount.FirstOrDefault(q => q.Question.Id == question.Id)?.AnswersCount ?? 0;
            }

            return Page();
        }
    }

    // Helper class to store question and its answers count
    public class StudentQuestionWithAnswersCount
    {
        public StudentQuestions StudentQuestion { get; set; }
        public int AnswersCount { get; set; }
    }
}
