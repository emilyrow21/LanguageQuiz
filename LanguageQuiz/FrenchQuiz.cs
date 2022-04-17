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
            Dictionary<int,QuizQuestion> frenchQuestions = new Dictionary<int,QuizQuestion>();
            QuizQuestion f1 = new QuizQuestion();
            f1.Question = "What tense is used here? 'L’année dernière, je suis allé en Espagne en vacances.'";
            f1.Answers = new Dictionary<int, string>();
            f1.Answers.Add(0, "Past");
            f1.Answers.Add(1, "Present");
            f1.Answers.Add(2, "Future");
            f1.CorrectAnswer = 0;
            frenchQuestions.Add(0, f1);

            f1 = new QuizQuestion();
            f1.Question = "How do you ask 'where are you going?' in french?";
            f1.Answers = new Dictionary<int, string>();
            f1.Answers.Add(0, "Où allez-vous?");
            f1.Answers.Add(1, "Comment allez-vous?");
            f1.Answers.Add(2, "Quel âge avez-vous?");
            f1.CorrectAnswer = 0;
            frenchQuestions.Add(1, f1);

            f1 = new QuizQuestion();
            f1.Question = "What is the correct term which is usually put in front to describe the weather?";
            f1.Answers = new Dictionary<int, string>();
            f1.Answers.Add(0, "C'est vent");
            f1.Answers.Add(1, "Demain, je serai tonnerre");
            f1.Answers.Add(2, "Il fait beau aujourd’hui");
            f1.CorrectAnswer = 2;
            frenchQuestions.Add(2, f1);
            return frenchQuestions;
        }
    }
}
