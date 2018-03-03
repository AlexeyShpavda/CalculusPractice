using System;

namespace ShadedArea
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the radius -->");
            double r = Double.Parse(Console.ReadLine());
            Console.Write("Enter x -->");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Enter y -->");
            double y = Double.Parse(Console.ReadLine());

            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r, 2)) && r >= 0)
            {
                if ((y >= 0 && x >= 0) && y >= x)
                {
                    Console.Write("Yes");
                }
                else if ((x <= 0 && y <= 0) && y <= x)
                {
                    Console.Write("Yes");
                }
                else
                {
                    Console.Write("No");
                }
            }
            else
            {
                Console.Write("No");
            }

            Console.ReadKey();
        }
    }
}
