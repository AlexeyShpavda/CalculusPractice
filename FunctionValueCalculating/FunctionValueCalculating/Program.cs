using System;

namespace FunctionValueCalculating
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter x --> ");
            double x = Double.Parse(Console.ReadLine());

            double y1, y2;

            y1 = Math.Cos(x) + Math.Sin(x) + Math.Cos(3.0 * x) + Math.Sin(3.0 * x);
            y2 = 1.0 / 4.0 - ((1.0 / 4.0) * (Math.Sin(((5.0 / 2.0) * Math.PI) - (8.0 * x))));

            Console.WriteLine("y1 = " + y1);
            Console.WriteLine("y2 = " + y2);

            Console.ReadKey();
        }
    }
}
