namespace LanguageQuiz
{
    internal class ReadFileBase
    {
        public string? FileName
        {
            get; set;
        }

        public string[] readLineIntoArray(StreamReader sr)
        {          
            string strLine = sr.ReadLine();

            return strLine.Split(',');
        }
    }
}