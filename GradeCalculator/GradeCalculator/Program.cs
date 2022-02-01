using GradeCalculator;

/* Grade Calculator 
 * by basti 
 * 
 * Session from 1.2.2022 22:48 / 23:16
 * 
 * revision v1.2
 * added spreadsheet format
 * added colors 
 */

class Program
{

    static void Main(string[]args)
    {
        int howmany = 3;
        int counter = 0;
        string name = "";

        Console.WriteLine("Grade Calculator:");
        Console.WriteLine("version v1.2");
        Console.WriteLine("");
        Console.WriteLine("Whats your name ?:");
        name = Console.ReadLine();
        Console.WriteLine("How many subjects do wana calculate? minimum 3");


        howmany = Convert.ToInt32(Console.ReadLine());

        subjectcon[] allgrade = new subjectcon[howmany];

        Console.WriteLine("Use the given syntax:");
        Console.WriteLine("subject, grade");

        while (howmany > 0)
        {
            try
            {
                
                string __subject;
                int __grade;

                string entry = Console.ReadLine();
                string[] _entry = entry.Split(",");

             
                __subject = _entry[0];
                __grade = Convert.ToInt32(_entry[1]);

                subjectcon entry1 = new subjectcon(name, __subject, __grade);
                allgrade[counter] = entry1; 
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
            Console.Clear();

            #region output

            int lengthname = 0;
            int lengthsubject = 0;

            foreach(subjectcon cony in allgrade)
            {
                if (cony.name.Length>lengthname)
                {
                   lengthname = cony.name.Length ;
                }
               
            }

            foreach (subjectcon cons in allgrade)
            {
                if (cons.subjectname.Length>lengthsubject)
                {
                    lengthsubject = cons.subjectname.Length;
                }
            }
            Console.WriteLine("{0,-10} | {1,-10}", "Subject", "Grade");

            Console.WriteLine("----------------------------");

            foreach (subjectcon con in allgrade)
            {
               if (con.grade == 1)
               {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
               }
               if (con.grade == 2)
               {
                    Console.BackgroundColor = ConsoleColor.Green;
               }
               if (con.grade == 3)
               {
                    Console.BackgroundColor = ConsoleColor.Yellow;
               }
               if (con.grade == 4)
               {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
               }
               if (con.grade == 5)
               {
                    Console.BackgroundColor = ConsoleColor.Red;
               }
               Console.WriteLine("{0,-10} | {1,-10}",  con.subjectname, con.grade);
            }

            Console.ResetColor();

            Console.WriteLine("----------------------------");


            #region calcaverage

            int averagegrade = 0;

            foreach(subjectcon sa in allgrade)
            {
                averagegrade = averagegrade + Convert.ToInt32(sa.grade);
            }


            averagegrade = averagegrade / allgrade.Length;
            Console.Write("Your average Grad is :");
            #region colorav
            if (averagegrade == 1)
               {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            if (averagegrade == 2)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (averagegrade == 3)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (averagegrade == 4)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            if (averagegrade == 5)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            Console.Write(averagegrade);
            Console.ResetColor();
            #endregion
            #endregion
            #endregion
        }

        else
            {
            Console.WriteLine("Okay bye");
            }

        Console.ReadKey();
        


    }
}
