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


            int[,] array = new int[2, 3];
            // row 1 
            array[1, 1] = 0;
            array[1, 2] = 1;
            array[1, 3] = 4;

            // row 2
            array[2, 1] = 9;
            array[2, 2] = 16;
            array[2, 3] = 25;

            // row 3

            array[3, 1] = 36;
            array[3, 2] = 49;
            array[3, 3] = 64;


            

            
        }


    }
}
