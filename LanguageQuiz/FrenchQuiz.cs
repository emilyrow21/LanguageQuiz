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
            //easy question
            Dictionary<int,QuizQuestion> frenchQuestions = new Dictionary<int,QuizQuestion>();
            QuizQuestion f1 = new QuizQuestion();
            f1.Question = "What tense is used here? 'L’année dernière, je suis allé(e) en Espagne en vacances.'";
            f1.Answers = new Dictionary<int, string>();
            f1.Answers.Add(0, "Past");
            f1.Answers.Add(1, "Present");
            f1.Answers.Add(2, "Future");
            f1.CorrectAnswer = 0;
            frenchQuestions.Add(0, f1);

            // easy/medium question
            f1 = new QuizQuestion();
            f1.Question = "How do you ask 'where are you going?' in french?";
            f1.Answers = new Dictionary<int, string>();
            f1.Answers.Add(0, "Où allez-vous?");
            f1.Answers.Add(1, "Comment allez-vous?");
            f1.Answers.Add(2, "Quel âge avez-vous?");
            f1.CorrectAnswer = 0;
            frenchQuestions.Add(1, f1);

            //medium level question
            f1 = new QuizQuestion();
            f1.Question = "What is the correct term which is usually put in front to describe the weather?";
            f1.Answers = new Dictionary<int, string>();
            f1.Answers.Add(0, "C'est vent");
            f1.Answers.Add(1, "Demain, je serai tonnerre");
            f1.Answers.Add(2, "Il fait beau aujourd’hui");
            f1.CorrectAnswer = 2;
            frenchQuestions.Add(2, f1);
            return frenchQuestions;


            // hard question example
            f1 = new QuizQuestion();
            f1.Question = "Comment diriez-vous 'Do you like French?' en Francais (plurel)";
            f1.Answers = new Dictionary <int, string>();
            f1.Answers.Add(0, "Vous aimez le Francais, non?");
            f1.Answers.Add (1, "Tu aimes la France?");
            f1.Answers.Add (2, "Vous aimes Francais, non?");
            f1.CorrectAnswer = 1;
            frenchQuestions.Add(1, f1);
            return frenchQuestions;
        }
    }
}
