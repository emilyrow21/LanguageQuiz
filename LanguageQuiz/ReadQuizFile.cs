using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using static LanguageQuiz.QuizQuestion;

namespace LanguageQuiz
{
    internal class ReadQuizFile : FileOperations
    {
        public ReadQuizFile(string? fileName)
        {
            FileName = fileName;
        }

        
        public Dictionary<int, QuizQuestion> QuizQuestions ()
        {
            try
            {
                Dictionary<int, QuizQuestion> result = new Dictionary<int, QuizQuestion>();

                StreamReader sr = new StreamReader(FileName);
                string[] values = null;
                int x = 0;
                while (!sr.EndOfStream)
                {
                    x++;
                    values = readLineIntoArray(sr);
                    QuizQuestion f1 = new QuizQuestion();
                    f1.ID = Convert.ToInt32(values[0]);
                    qlevel level;
                    Enum.TryParse(values[1], out level);
                    f1.level = level;
                    qType qt;
                    Enum.TryParse(values[2], out qt);
                    f1.questionType = qt;

                    f1.Question = values[3];

                    if (qt == qType.multiChoice)
                    {
                        f1.CorrectAnswer = Convert.ToInt32(values[4]);
                        f1.Answers = new List<Answer>();
                        int numberofanswers = values.Length - 4;
                        for (int i = 5; i < values.Length; i++)
                        {
                            f1.Answers.Add(new Answer(i - 5, values[i]));
                        }

                        f1.CorrectAnswer = Convert.ToInt32(values[4]);
                    }
                    else if (qt == qType.translation)
                    {
                        // TODO
                    }

                    result.Add(f1.ID, f1);

                }
                sr.Close();
                return result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Dictionary<int, QuizQuestion> nullresult = new Dictionary<int, QuizQuestion>();
                return nullresult;
            }
        }
    }
}
