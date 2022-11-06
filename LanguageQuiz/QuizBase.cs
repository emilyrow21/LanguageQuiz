using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LanguageQuiz
{
    public abstract class QuizBase
    {
        string? currentUser;
        Dictionary<int, QuizQuestion>? allquestions;
        int currentQuestion = 0;
        private int score;
        QuizQuestion quizQuestion;

        public int Score { get => score; }
        public QuizQuestion getQuestion { get => quizQuestion; }
        public Boolean checkanswer(string response)
        {
            int answer = Convert.ToInt32(response);
            if (answer == quizQuestion.CorrectAnswer)
            {
                score++;
                return true;

            }
            else
            {
                return false;
            }
        }
        protected abstract  Dictionary<int,QuizQuestion> FindQuizQuestions();
        protected Boolean authenticatePlayer(string name)
        {
            // User logs in with name
            currentUser = name;
            return true;
        }

        public QuizQuestion nextQuestion()
        {
            if (currentQuestion + 1 <= allquestions.Count)
            {
                currentQuestion++;
                quizQuestion = allquestions[currentQuestion];
            }
            else
            {
                quizQuestion = null;
            }
            return quizQuestion;
        }

        public void startQuiz()
        {
            allquestions = FindQuizQuestions();
        }
        

        public QuizQuestion GetNextQuestion()
        {
            QuizQuestion q1 = null;
            q1 = nextQuestion();

            return q1;

        }
    }

}
