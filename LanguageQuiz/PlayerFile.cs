using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageQuiz
{
    internal class PlayerFile : FileOperations
    {
        public userProfile getProfile(string userName)
        {
            return new userProfile();
        }
    }
}
