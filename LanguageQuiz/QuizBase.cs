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
        QuizQuestion nextquestion;

        public int Score { get => score; }

        public Boolean checkanswer(string response)
        {
            int answer = Convert.ToInt32(response);
            if (answer == nextquestion.CorrectAnswer)
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
                nextquestion = allquestions[currentQuestion];
            }
            else
            {
                nextquestion = null;
            }
            return nextquestion;
        }

        public void startQuiz()
        {
            allquestions = FindQuizQuestions();
        }
        

        public QuizQuestion GetQuestion()
        {
            QuizQuestion q1 = null;
            q1 = nextQuestion();

            return q1;

            // QuizQuestion q2 = null;
            // q2 = nextQuestion();

            //return q2;

            //QuizQuestion q3 = null;
            //q3 = nextQuestion();

            //return q3;

        }
    }

}
