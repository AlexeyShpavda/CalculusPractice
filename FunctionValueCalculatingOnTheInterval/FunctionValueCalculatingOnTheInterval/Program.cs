using System;

namespace FunctionValueCalculatingOnTheInterval
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter x --> ");
            double x = double.Parse(Console.ReadLine());
 
            double y = 0, r = 3;

            if (x >= -9 && x <= -6)
            {
                y = -1 * Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x + 6, 2));
            }
            else if (x > -6 && x < -3)
            {
                y = 3 + x;
            }
            else if (x >= -3 && x <= 0)
            {
                y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2));
            }
            else if (x > 0 && x <= 3)
            {
                y = 3 - x;
            }
            else if (x > 3 && x <= 9)
            {
                y = (x - 3) / 2;
            }
            else
            {
                Console.WriteLine("Error!");
            }

            Console.Write("\ny=" + y);

            Console.ReadKey();
        }
    }
}
