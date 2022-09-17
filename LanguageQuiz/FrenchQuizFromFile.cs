using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageQuiz
{
    internal class FrenchQuizFromFile : QuizBase
    {
        protected override Dictionary<int, QuizQuestion> FindQuizQuestions()
        {
            ReadQuizFile quiz = new ReadQuizFile(@"c:\Quiz\FrenchQuestions.txt");
            return quiz.QuizQuestions();
        }
    }
}
