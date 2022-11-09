using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LanguageQuiz;
namespace QuizPages.Pages
{

    public class QuizQuestionModel : PageModel
    {
        public string Username { get; set; }
        public QuizQuestion currentQuestion;
        private string questionsAnswered;
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
        }
        public void OnGet(string _username)
        {
            Username = Request.RouteValues["username"].ToString();
            questionsAnswered = Request.RouteValues["quiz"].ToString();
            currentQuestion = quiz.GetNextQuestion(Username,questionsAnswered);
            questionsAnswered = string.Format("{0}&{1}", questionsAnswered, currentQuestion.ID);
            Request.RouteValues["quiz"] = questionsAnswered;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
                return Page();

            Username = Request.RouteValues["username"].ToString();
            questionsAnswered = Request.RouteValues["quiz"].ToString();
            // TODO: Save result for end
            return RedirectToPage("./QuizQuestion",new {username = Username, quiz = questionsAnswered });
        }

    }
}
