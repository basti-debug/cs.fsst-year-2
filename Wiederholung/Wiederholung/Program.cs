using System;

namespace Wiederholung
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = square(2);
            Console.WriteLine(y);
            Console.ReadKey();

            //arrays();
            /*
            int x = 2;
            while (x < 5)
            {
                if (x == 3)
                {
                    x++;
                    continue;
                    
                }
                Console.WriteLine(x);
                x++;

            }

            Console.ReadKey();
            */
        }

        static void arrays()
        {
            int[] values = new int[10];

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = i + 1;
            }
            for(int i = 0; i == values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }

            int a = values[0];
            int b = values[1];

            int x = values[0] + values[1];
            int z = a + b;

            Console.ReadKey();
        }

        public static int square(int x)
        {
            return x * x;
        }


        




    }
}
