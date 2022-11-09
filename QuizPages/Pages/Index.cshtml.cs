using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QuizPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string username { get; set; }
        public string msg { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if(!username.Equals(""))
            {
                return RedirectToPage("QuizQuestion", new {username = username, quiz = "empty"});
            }
            else
            {
                msg = "unknown";
                return Page();
            }
        }
    }
}