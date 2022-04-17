// See https://aka.ms/new-console-template for more information
using LanguageQuiz;

Console.WriteLine("French quiz");

FrenchQuiz quiz = new FrenchQuiz();

quiz.startQuiz();

QuizQuestion nextQuestion=null;

do
{
    nextQuestion = quiz.GetQuestion();
    if (nextQuestion!=null)
    {
        Console.WriteLine(nextQuestion.Question);
        foreach (var answer in nextQuestion.Answers)
        {
            Console.Write(answer.Key + ". ");

            Console.WriteLine(answer.Value);

        };
        String UserInput = Console.ReadLine();
        

        //int UserInputInt = Convert.ToInt32(UserInput);
        
        
        
        if (quiz.checkanswer(UserInput) == true)
        { 
            Console.WriteLine("This is the right answer.");
        }
        else
        {
            Console.WriteLine("This the wrong answer.");
        }
    }
    
} while (nextQuestion != null);

Console.WriteLine("your score was " + quiz.Score);





//QuizQuestion q = quiz.GetQuestion();

//Console.WriteLine(q.Question);

//Console.WriteLine(q.Answers[0]);

//foreach (var answer in q.Answers)
//{
//    Console.Write(answer.Key+". ");
    
//    Console.WriteLine(answer.Value);
    

//};
//String UserInput= Console.ReadLine();
//int UserInputInt= Convert.ToInt32(UserInput);
//if (UserInputInt == q.CorrectAnswer)
//{
//    Console.WriteLine("This is the right answer.");
//}
//else
//{
//    Console.WriteLine("This the wrong answer.");
//}
