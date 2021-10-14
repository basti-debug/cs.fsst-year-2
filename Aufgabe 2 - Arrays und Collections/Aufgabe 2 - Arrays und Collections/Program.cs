using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2___Arrays_und_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
           // Aufgabe A

            int x = 0;
            int y = 0;
            int count = 0;
            string query;

            Console.WriteLine("Installed Programms: ./uebungsaufgabe2.exe    ./randomcollection.exe");
            Console.WriteLine();
            Console.WriteLine("select programm: ");

            query = Convert.ToString(Console.ReadLine());
            if (query == "./uebungsaufgabe2.exe")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Array ersteller v1");
                Console.WriteLine("Dimensionen angeben: ");


                Console.Write("Wert für x: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Wert für y: ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                int[,] array1 = new int[x, y];

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        count++;
                        array1[i, j] = count * count;
                        Console.Write(array1[i, j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            if (query == "./randomcollection.exe")
            {
                Random rnd = new Random();
                var colllection1 = new List<int>();
                int sum = 100;
                int didgits = 0;
                int dividable = 0;
                for (int l = 0; l < sum; l++)
                {
                    colllection1.Add(rnd.Next());
                }

                for(int z = 0; z <colllection1.Count(); z++)
                {
                    if (colllection1[z].ToString().Length == 3)
                    {
                        didgits++;
                    }
                    if (colllection1[z] % 7 == 0)
                    {
                        dividable++;
                    }
                }

                Console.WriteLine("Zahlen mit 3 Stellen: " + didgits);
                Console.WriteLine("Zahlen die ohne Rest durch 7 teilbar sind: " + dividable);
                

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a existing Program");
                Console.WriteLine("restart to try again");
            }

            Console.ReadKey();

            


        }
    }
}
