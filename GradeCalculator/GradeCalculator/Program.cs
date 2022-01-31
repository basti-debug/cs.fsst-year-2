using System;
using GradeCalculator;

/* Grade Calculator 
 * by basti 
 * 
 * Session from 19.1.2022
 * 
 * v0.1 
 */

class Program
{

    static void Main(string[]args)
    {

        List<subjectcon> allgrades = new List<subjectcon >();
        int howmany = 4;
        

        Console.WriteLine("Grade Calculator:");
        Console.WriteLine("version v0.2");
        Console.WriteLine("");
        Console.WriteLine("How many subjects do wana calculate?");

        howmany = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Please enter at least 4 subjects");
        Console.WriteLine("Use the given syntax:");
        Console.WriteLine("yourname, subject, grade");

        while (howmany > 0)
        {
            try
            {
                string __name;
                string __subject;
                int __grade;

                string entry = Console.ReadLine();
                string[] _entry = entry.Split(",");

                __name = _entry[0];
                __subject = _entry[1];
                __grade = Convert.ToInt32(_entry[2]);

                subjectcon entry1 = new subjectcon(__name, __subject, __grade);
                allgrades.Add(entry1);
                Console.WriteLine("check");
                howmany--;

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid format");
            }
        }
            string selection1;

            do
            {
                Console.WriteLine("Do you wana calculate your average Grade ? ");
                selection1 = Console.ReadLine();
            } while ((selection1 != "y") && (selection1 != "n"));

            if (selection1 == "y")
            {

                // fill array - wait with that 

                string[] = new string[] {}

               


                Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
            for (int ctr = 0; ctr < .Length; ctr++)
                Console.WriteLine("{0-20} {1,5:N1}")
            }


        Console.ReadKey();
        


    }
}
