using System;

namespace TaylorSeries
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the initial x --> ");
                double initial = double.Parse(Console.ReadLine());
                Console.Write("Enter the final x --> ");
                double final = double.Parse(Console.ReadLine());

                if ((Math.Abs(initial) <= 1) || (Math.Abs(final) <= 1) || (initial > final))
                {
                    Console.WriteLine("\nError! Wrong borders.\n");
                    Main();
                }

                Console.Write("Enter the step --> ");
                double dx = double.Parse(Console.ReadLine());
                Console.Write("Enter the accuracy --> ");
                double e = double.Parse(Console.ReadLine());

                double x = initial;

                string header = "Table", line = "|------------------------------------------|";
                Console.WriteLine("{0,23}", header);
                Console.WriteLine(line);
                Console.WriteLine("|{0, -10}|{1, -20}|{2, -10}|", "x", "y", "i");
                Console.WriteLine(line);


                for (var n = 1; n <= 10 && x <= final; n++, x += dx)
                {
                    if (Math.Abs(x) > 1)
                    {
                        x = Math.Round(x, 3);

                        double y = 0;
                        ushort i = 0;
                        for (; Math.Abs(2 / ((2 * i + 1) * Math.Pow(x, (2 * i + 1)))) > e; i++)
                        {
                            y += 2 / ((2 * i + 1) * Math.Pow(x, (2 * i + 1)));
                        }

                        Console.WriteLine("|{0, -10}|{1, -20}|{2, -10}|", x, y, i);
                        Console.WriteLine(line);
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nError! Division by zero.\n");
                Main();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError! Invalid input.\n");
                Main();
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nError! Overflow.\n");
                Main();
            }

            Console.ReadKey();
        }
    }
}