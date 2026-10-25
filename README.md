A French language quiz built in C# as a personal project (2022–23). 
It runs as a console app and as a multi-page ASP.NET Core Razor Pages web app. 
The quiz picks questions to match how well the player is doing.

Features
Multiple-choice questions at three difficulty levels (easy, medium, hard)
Adaptive difficulty: the next question's level depends on the player's previous answers
Answer history is tracked so questions are not repeated
Automatic scoring and answer checking
Questions loaded from an external data file
Web interface with home, question and results pages, keeping quiz progress between page posts

How it works
QuizBase is an abstract class holding the quiz logic (scoring, moving through questions, difficulty selection).
FrenchQuiz extends it and supplies the French questions.
ReadQuizFile reads the question file and builds a dictionary of QuizQuestion objects (ID, difficulty, type, question text, 
answers, correct answer).
The player rating is weighted by difficulty, so hard questions count for more.
Project structure
LanguageQuiz/ – quiz logic, question and answer classes, file reading, console app
QuizPages/ – ASP.NET Core Razor Pages web app (Index, QuizQuestion and Result pages)

Status
Built in 2022–23 and not actively developed since. Translation-type questions and user profiles are stubbed out but not finished.
Built with
C#, .NET, ASP.NET Core Razor Pages
