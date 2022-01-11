using System;
using System.Text.RegularExpressions;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex rx = new Regex(@"^S\d{4}$");
            string studentNumber = "";

            Console.WriteLine("Please enter Student ID Number: ");

            

            studentNumber = Console.ReadLine();

            bool passed = rx.IsMatch(studentNumber);
            if (!passed)
            {
                throw new InvalidStudentNumberException();
            }
            

            Console.ReadKey();
           
        }
    }
}
