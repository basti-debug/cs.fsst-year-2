using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exceptions
{
    class InvalidStudentNumberException : Exception
    {
        
        public string Pattern { get; set; }

        public InvalidStudentNumberException()
        {
            Pattern = "Student-ID has to follow the pattern: /^S\u005cd{4}$/.";
        }
        
    }
}
