using System;
using System.Text.RegularExpressions;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex rx = new Regex(@"^S\d{4}$");

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter Student ID Number: ");
            string id = Console.ReadLine();

            try
            {
                if(rx.IsMatch(id))
                {
                    student s = new student(name,id);
                    Console.WriteLine("New Student has been successfully created!");
                }
                else
                {
                    throw new InvalidStudentNumberException();
                }
            }
            catch (InvalidStudentNumberException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Pattern);
            }

            

            


            Console.ReadKey();
           
        }
    }
}
