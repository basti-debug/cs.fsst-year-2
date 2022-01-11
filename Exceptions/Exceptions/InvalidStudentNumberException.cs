using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exceptions
{
    class InvalidStudentNumberException : Exception
    {
        
        string message = "Student-ID has to follow the pattern: /^S/d{4}$/";
        public InvalidStudentNumberException()
        {
            Console.WriteLine(message);
        }

        public InvalidStudentNumberException(string message) : base(message)
        {

        }

        public InvalidStudentNumberException(string message, Exception innerException) : base(message, innerException)
        {
            Console.WriteLine(message, innerException);
        }
        
    }
}
