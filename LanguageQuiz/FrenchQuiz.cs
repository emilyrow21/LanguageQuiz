using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageQuiz
{
    internal class FrenchQuiz : QuizBase
    {
        protected override Dictionary<int, QuizQuestion> FindQuizQuestions()
        {
            //easy =0   medium = 1  hard =2
            //easy question
            Dictionary<int,QuizQuestion> frenchQuestions = new Dictionary<int,QuizQuestion>();
            QuizQuestion f1 = new QuizQuestion();
            f1.Question = "What tense is used here? 'L’année dernière, je suis allé(e) en Espagne en vacances.'";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, "Past"));
            f1.Answers.Add(new Answer(1, "Present"));
            f1.Answers.Add(new Answer(2, "Future"));
            f1.CorrectAnswer = 0;
            frenchQuestions.Add(0, f1);

            // easy/medium question
            f1 = new QuizQuestion();
            f1.Question = "How do you ask 'where are you going?' in french?";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, "Où allez-vous?"));
            f1.Answers.Add(new Answer(1, "Comment allez-vous?"));
            f1.Answers.Add(new Answer(2, "Quel âge avez-vous?"));
            f1.CorrectAnswer = 0;
            frenchQuestions.Add(1, f1);

            //medium level question
            f1 = new QuizQuestion();
            f1.Question = "What is the correct term which is usually put in front to describe the weather?";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, "C'est vent"));
            f1.Answers.Add(new Answer(1, "Demain, je serai tonnerre"));
            f1.Answers.Add(new Answer(2, "Il fait beau aujourd’hui"));
            f1.CorrectAnswer = 2;
            frenchQuestions.Add(2, f1);
            return frenchQuestions;


            // hard question example
            f1 = new QuizQuestion();
            f1.Question = "Comment diriez-vous 'Do you like French?' en Français (plurel)";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, "Tu aimes la France?"));
            f1.Answers.Add (new Answer(1, "Vous aimez le Français non?"));
            f1.Answers.Add (new Answer(2, "Vous aimes Français non?"));
            f1.Answers.Add(new Answer(3, "Tu aimez Francais?"));
            f1.CorrectAnswer = 1;
            frenchQuestions.Add(0, f1);
            return frenchQuestions;

            //medium
            f1 = new QuizQuestion();
            f1.Question = "Select the option which is postive";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, ""));
            f1.Answers.Add(new Answer(1, ""));
            f1.Answers.Add(new Answer(2, ""));
            f1.CorrectAnswer = 1;
            frenchQuestions.Add(0, f1);
            return frenchQuestions;

            //easy
            f1 = new QuizQuestion();
            f1.Question = "how would you greet someone you see in French?";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, "Au revoir"));
            f1.Answers.Add(new Answer(1, "Aujourd'hui je suis fatiguee"));
            f1.Answers.Add(new Answer(2, "Salut ça va ?"));
            f1.CorrectAnswer = 2;
            frenchQuestions.Add(0, f1);
            return frenchQuestions;

            //hard
            f1 = new QuizQuestion();
            f1.Question = "Quel est faux ici? ' ";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, ""));
            f1.Answers.Add(new Answer(1, ""));
            f1.Answers.Add(new Answer(2, ""));
            f1.CorrectAnswer = 1;
            frenchQuestions.Add(0, f1);
            return frenchQuestions;

            //hard
            f1 = new QuizQuestion();
            f1.Question = " ";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, ""));
            f1.Answers.Add(new Answer(1, ""));
            f1.Answers.Add(new Answer(2, ""));
            f1.CorrectAnswer = 0;
            frenchQuestions.Add(0, f1);
            return frenchQuestions;

            //medium
            f1 = new QuizQuestion();
            f1.Question = " ";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, ""));
            f1.Answers.Add(new Answer(1, ""));
            f1.Answers.Add(new Answer(2, ""));
            f1.CorrectAnswer = 1;
            frenchQuestions.Add(0, f1);
            return frenchQuestions;

            //easy
            f1 = new QuizQuestion();
            f1.Question = "What word in French means 'dog'?";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, "chien"));
            f1.Answers.Add(new Answer(1, "rien"));
            f1.Answers.Add(new Answer(2, "chat"));
            f1.CorrectAnswer = 0;
            frenchQuestions.Add(0, f1);
            return frenchQuestions;

            //hard
            f1 = new QuizQuestion();
            f1.Question = "Select the option in French which translates to 'Today will be a good day because i am meeting my friends'.";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, ""));
            f1.Answers.Add(new Answer(1, ""));
            f1.Answers.Add(new Answer(2, ""));
            f1.CorrectAnswer = 2;
            frenchQuestions.Add(0, f1);
            return frenchQuestions;

            //easy
            f1 = new QuizQuestion();
            f1.Question = "What is brother in French?";
            f1.Answers = new List<Answer>();
            f1.Answers.Add(new Answer(0, "sœur"));
            f1.Answers.Add(new Answer(1, "Frère"));
            f1.Answers.Add(new Answer(2, "Bien"));
            f1.CorrectAnswer = 1;
            frenchQuestions.Add(0, f1);
            return frenchQuestions;


        }
    }
}
