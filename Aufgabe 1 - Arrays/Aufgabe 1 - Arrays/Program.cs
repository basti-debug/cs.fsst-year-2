using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aufgabe A - Array erzeugen

            int x = 10;
            int[] nameofarray = new int[x];

            for(int i = 0; i<10; i++)
            {
                nameofarray[i] = i;
               
            }

            //Aufgabe B - Arbeiten mit Arrays

            int[] values = new int[8] { -2, -7, 0, 3, 8, 4, 17, -1 };

            //größte Zahl 
            Console.WriteLine(values.Max());

            //kleinste Zahl
            Console.WriteLine(values.Min());

            //Summe aller Zahlen
            Console.WriteLine(values.Sum());

            //geraden Zahlen 

            for(int j = 0; j<values.Length;j++)
            {
                if ((values[j]%2) == 0)
                {
                    Console.WriteLine(values[j] + " gerade");
                }

                else
                {
                    Console.WriteLine(values[j] + " ungerade");
                }

            }

            //ungerade Zahlen

            Console.ReadKey();
            
        }
    }
}
