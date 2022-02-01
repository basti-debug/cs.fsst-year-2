using System;
using GradeCalculator;

/* Grade Calculator 
 * by basti 
 * 
 * Session from 1.2.2022
 * 
 * v0.2 
 */

class Program
{

    static void Main(string[]args)
    {
        int howmany = 4;
        int counter = 0;

        Console.WriteLine("Grade Calculator:");
        Console.WriteLine("version v0.2");
        Console.WriteLine("");
        Console.WriteLine("How many subjects do wana calculate? minimum 4");


        howmany = Convert.ToInt32(Console.ReadLine());

        subjectcon[] allgrade = new subjectcon[howmany];

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
                allgrade[counter] = entry1; 
                Console.WriteLine("check");
                howmany--;
                counter++;
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
            int lengthname = 0;
            int lengthsubject = 0;

            foreach(subjectcon cony in allgrade)
            {
                if (cony.name.Length>lengthname)
                {
                   lengthname = cony.name.Length ;
                }
               
            }

            foreach(subjectcon cons in allgrade)
            {
                if (cons.subjectname.Length>lengthsubject)
                {
                    lengthsubject = cons.subjectname.Length;
                }
            }
            Console.WriteLine(lengthname);
            Console.WriteLine(lengthsubject); 
            Console.WriteLine("{0", lengthname, "} {1,",lengthsubject,"} {2,10}", "Name", "Subject", "Grade");

            foreach(subjectcon con in allgrade)
            {

               Console.WriteLine("{0", -lengthname,"} {1,",-lengthsubject,"} {2,10}", con.name, con.subjectname, con.grade);
            }


            Console.WriteLine("déam");
            }


        Console.ReadKey();
        


    }
}
