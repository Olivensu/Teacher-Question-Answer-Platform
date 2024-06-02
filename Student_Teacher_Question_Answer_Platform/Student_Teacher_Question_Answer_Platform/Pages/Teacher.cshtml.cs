using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Student_Teacher_Question_Answer_Platform.Pages
{
    [Authorize(Roles = "teacher")]
    public class TeacherModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
