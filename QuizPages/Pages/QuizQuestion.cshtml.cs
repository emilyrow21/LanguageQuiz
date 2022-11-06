using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LanguageQuiz;
namespace QuizPages.Pages
{

    public class QuizQuestionModel : PageModel
    {
        public string Username { get; set; }
        public QuizQuestion currentQuestion;
        FrenchQuizFromFile quiz;
        [BindProperty]
        public List<int> answerbox { get; set;}
        public QuizQuestionModel()
        {
            if(quiz == null)
            {
                quiz = new FrenchQuizFromFile();
                quiz.startQuiz();
            }
            currentQuestion = quiz.GetNextQuestion();
        }
        public void OnGet(string _username)
        {
            Username = _username;
            currentQuestion = quiz.GetNextQuestion();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
                return Page();
            // Check answer, save result. Resubmit.

            return RedirectToPage("./QuizQuestion");
        }

    }
}
