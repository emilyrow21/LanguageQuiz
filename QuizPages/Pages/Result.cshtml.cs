using LanguageQuiz;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QuizPages.Pages
{
    public class ResultModel : PageModel
    {
        public string Username { get; set; }
        public string playerRating { get; set;}
        public QuizQuestion currentQuestion;
        private string questionsAnswered;
        FrenchQuizFromFile quiz;
        public async Task<IActionResult> OnGet(string _username)
        {
            Username = Request.RouteValues["username"].ToString();
            
            questionsAnswered = Request.RouteValues["quiz"].ToString();

            quiz = new FrenchQuizFromFile();
            playerRating = quiz.GetPlayerRating(Username,questionsAnswered);

            return null;
        }
    }
}
