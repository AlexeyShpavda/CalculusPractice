using System;

namespace UsingTryCatch
{
    class Program
    {
        static void Main()
        {
            short exit = 0;
            try
            {
                Console.Write("Enter x --> ");
                double x = double.Parse(Console.ReadLine());

                double y1, y2;

                y1 = Math.Cos(x) + Math.Sin(x) + Math.Cos(3.0 * x) + Math.Sin(3.0 * x);
                y2 = 1.0 / 4.0 - ((1.0 / 4.0) * (Math.Sin(((5.0 / 2.0) * Math.PI) - (8.0 * x))));

                Console.WriteLine("y1 = " + y1);
                Console.WriteLine("y2 = " + y2);

                do
                {
                    Console.Write("Enter 1 to complete or 0 to continue --> ");
                    exit = short.Parse(Console.ReadLine());
                }
                while ((exit != 1) && (exit != 0));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ERROR! Division by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR! Invalid input!");
            }
            finally
            {
                if (exit == 0) Main();
            }
        }
    }
}
