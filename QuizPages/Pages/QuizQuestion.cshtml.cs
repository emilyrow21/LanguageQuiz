using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LanguageQuiz;
namespace QuizPages.Pages
{

    public class QuizQuestionModel : PageModel
    {
        public string Username { get; set; }
        public QuizQuestion nextQuestion;

        public QuizQuestionModel()
            : base()
        {
            FrenchQuizFromFile quiz = new FrenchQuizFromFile();
            quiz.startQuiz();
            nextQuestion = quiz.GetQuestion();
        }
        public void OnGet(string _username)
        {
            Username = _username;
        }
    }
}
