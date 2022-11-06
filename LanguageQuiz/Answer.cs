using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageQuiz
{
    public class Answer
    {
        public string? answerText { get; set; }
        public bool answerChecked { get; set; }
        public int key { get; set; }

        public Answer(int key,string? answerText)
        {
            this.answerText = answerText;
            this.answerChecked = false;
            this.key = key;
        }
    }
}
