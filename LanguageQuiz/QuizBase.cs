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
        private QuizQuestion.qlevel GetAIRating(string username, string quizHistory)
        {
            string[] QuestionAndAns = quizHistory.Split('&');
            int QuestionId;
            QuizQuestion checkQuestion;
            int easy=0,medium=0,hard=0;

            if (QuestionAndAns.Length > 1)
            {
                for (int i = 1; i < QuestionAndAns.Length; i += 2)
                {
                    QuestionId = System.Convert.ToInt32(QuestionAndAns[i]);
                    FindQuizQuestions().TryGetValue(QuestionId, out checkQuestion);
                    if (checkQuestion != null && checkQuestion.CorrectAnswer == Convert.ToInt32(QuestionAndAns[i + 1]))
                    {
                        if (checkQuestion.level == QuizQuestion.qlevel.easy)
                        {
                            easy++;
                        }
                        else if (checkQuestion.level == QuizQuestion.qlevel.medium)
                        {
                            medium++;
                        }
                        else
                        {
                            hard++;
                        }
                    }

                }
            }
            // AI Steps:
            if(easy == 0 && medium == 0 && hard == 0)
            { 
                return QuizQuestion.qlevel.easy;
            }
            if(easy > 0 && medium ==0 && hard == 0)
            { 
                return QuizQuestion.qlevel.medium;    
            }
            if(easy > 0 && medium > 0 && hard == 0)
            {
                return QuizQuestion.qlevel.hard;
            }

            if(easy>0 && medium > 0 && hard==0)
            {
                return QuizQuestion.qlevel.hard;
            }

            return QuizQuestion.qlevel.easy;
        }
        public string GetPlayerRating(string username, string quizHistory)
        {
            string[] QuestionAndAns = quizHistory.Split('&');
            int QuestionId;
            QuizQuestion checkQuestion;
            int playerRating = 0;

            if (QuestionAndAns.Length > 1)
            {
                for (int i = 1; i < QuestionAndAns.Length; i += 2)
                {
                    QuestionId = System.Convert.ToInt32(QuestionAndAns[i]);
                    FindQuizQuestions().TryGetValue(QuestionId,out checkQuestion);
                    if(checkQuestion != null && checkQuestion.CorrectAnswer == Convert.ToInt32(QuestionAndAns[i+1]))
                    {
                        if(checkQuestion.level == QuizQuestion.qlevel.easy)
                        {
                            playerRating++;
                        }
                        else if(checkQuestion.level == QuizQuestion.qlevel.medium)
                        {
                            playerRating+=10;
                        }
                        else
                        {
                            playerRating+=100;
                        }
                    }

                }
            }
            
            return playerRating.ToString();
        }
        public QuizQuestion GetNextQuestion(string username, string quizHistory)
        {
            QuizQuestion q1 = null;
            Boolean foundQuestion = false;
            List<int> QuestionIds = GetQuestionsFromHistory(quizHistory);
            QuizQuestion.qlevel playerAIRating = GetAIRating(username, quizHistory);
            
            do
            {
                q1 = nextQuestion();
                if (q1 == null)
                {

                    break;
                }
                if (!QuestionIds.Contains(q1.ID))
                {
                    // Check with AI to see if this question is appropriate
                    if(q1.level == playerAIRating)        
                        foundQuestion = true;
                }
            } while (!foundQuestion);
            return q1;
        }

        private static List<int> GetQuestionsFromHistory(string quizHistory)
        {
            string[] QuestionAndAns = quizHistory.Split('&');
            List<int> QuestionIds = new List<int>();
            if(QuestionAndAns.Length > 1)
            { 
                for (int i = 1; i < QuestionAndAns.Length; i+=2)
                {
                    QuestionIds.Add(System.Convert.ToInt32(QuestionAndAns[i]));
                }
            }
            return QuestionIds;
        }
    }

}
