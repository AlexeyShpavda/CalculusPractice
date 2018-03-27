using System;
using System.Linq;

namespace WorkWithArray
{
    class Program
    {
        static double[] array = new double[] { 1, 2, 3, 4, 0, 10, 0, 15 };
        static string line = "\n-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-\n";

        static void Main()
        {
            double minimumElementOfArray = array.Min();

            Console.WriteLine("Minimum element of the array is " + minimumElementOfArray);

            Console.WriteLine(line);

            double sumOfArrayElements = 0; // Between the first and the last positive elements
            int indexOfFirstPositiveElement = 0, indexOfLastPositiveElement = 0;

            FindIndecesOfFirstAndLastPositiveElement
                (ref indexOfFirstPositiveElement, ref indexOfLastPositiveElement);

            CountSumOfArrayElements
                (ref sumOfArrayElements, indexOfFirstPositiveElement, indexOfLastPositiveElement);

            Console.WriteLine("Sum of elements between first and last positive elements of array is "
                + sumOfArrayElements);

            Console.WriteLine(line);

            Console.Write("{0,-35}", "Initial array: ");
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.Write("\nArray with zeros at the beginning: ");
            MoveZerosToBeginningOfArray();
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }

            Console.ReadKey();
        }

        static void FindIndecesOfFirstAndLastPositiveElement
            (ref int indexOfFirstPositiveElement, ref int indexOfLastPositiveElement)
        {
            bool isFirstPositiveElementFound = false, isLastPositiveElementFound = false;

            for (var i = 0; i < array.Length && (!isFirstPositiveElementFound && !isLastPositiveElementFound); i++)
            {
                if (array[i] > 0 && !isFirstPositiveElementFound)
                {
                    indexOfFirstPositiveElement = i;
                    isFirstPositiveElementFound = true;
                }
                if (array[array.Length - i - 1] > 0 && !isLastPositiveElementFound)
                {
                    indexOfLastPositiveElement = array.Length - i - 1;
                    isLastPositiveElementFound = true;
                }
            }
        }

        /// Between the first and the last positive elements
        static void CountSumOfArrayElements
            (ref double sumOfArrayElements, int indexOfFirstPositiveElement, int indexOfLastPositiveElement)
        {
            for (int i = indexOfFirstPositiveElement + 1; i < indexOfLastPositiveElement; i++)
            {
                sumOfArrayElements += array[i];
            }
        }

        static void MoveZerosToBeginningOfArray()
        {
            int indexForZero = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    double veriableToMoveZero = array[indexForZero];
                    array[indexForZero] = array[i];
                    array[i] = veriableToMoveZero;
                    indexForZero++;
                }
            }
        }
    }
}
