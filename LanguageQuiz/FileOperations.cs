namespace LanguageQuiz
{
    internal class FileOperations
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

        public Boolean savethefile(string[] lines)
        {
            return true;
        }
    }
}