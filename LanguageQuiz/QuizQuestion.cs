using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageQuiz
{
    internal class QuizQuestion
    {
        string? question;
        Dictionary<int, string>? answers;
        int correctAnswer;
        public int ID { get; set; }
       
        public enum qlevel
        {
            easy, medium, hard
        }
        public enum qType
        {
            multiChoice,translation
        }
        public qlevel level { get; set; }
        public qType questionType { get; set; }

        public string? Question { get => question; set => question = value; }
        public Dictionary<int, string>? Answers { get => answers; set => answers = value; }
        public int CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        
     
    }
}
