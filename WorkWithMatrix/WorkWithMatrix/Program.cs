using System;

namespace WorkWithMatrix
{
    class Program
    {
        const int numberOfRowsMatrix = 4;
        const int numberOfColumnMatrix = 2;
        static int[,] matrix = new int[numberOfRowsMatrix, numberOfColumnMatrix] { { -1, -1 }, { -4, -10 }, { 0, 0 }, { -2, -2 } };

        static void Main()
        {
            int numberOfFirstColumnContainingZero = -1;

            DisplayMatrixOnTheScreen();

            LookingForColumnNumberContainingZero(ref numberOfFirstColumnContainingZero);

            if (numberOfFirstColumnContainingZero != -1)
            {
                Console.WriteLine("\nNumber of the first column containing zero is " + numberOfFirstColumnContainingZero + "\n");
            }
            else
            {
                Console.WriteLine("\nColumn containing zero not found\n");
            }

            SortBySpecialParametr();

            DisplayMatrixOnTheScreen();

            Console.ReadKey();
        }

        static void DisplayMatrixOnTheScreen()
        {
            for (var currentIndexInRow = 0; currentIndexInRow < numberOfRowsMatrix; currentIndexInRow++)
            {
                for (var currentIndexInColumn = 0; currentIndexInColumn < numberOfColumnMatrix; currentIndexInColumn++)
                {
                    Console.Write(matrix[currentIndexInRow, currentIndexInColumn] + " ");
                }
                Console.Write("\n");
            }

        }

        static void LookingForColumnNumberContainingZero(ref int numberOfFirstColumnContainingZero)
        {
            bool isColumnContainingZeroFound = false;
            for (var currentIndexInRow = 0; (currentIndexInRow < numberOfRowsMatrix) &&
                (!isColumnContainingZeroFound); currentIndexInRow++)
            {
                for (var currentIndexInColumn = 0; (currentIndexInColumn < numberOfColumnMatrix) &&
                    (!isColumnContainingZeroFound); currentIndexInColumn++)
                {
                    if (matrix[currentIndexInRow, currentIndexInColumn] == 0)
                    {
                        numberOfFirstColumnContainingZero = currentIndexInColumn + 1;
                        isColumnContainingZeroFound = true;
                    }
                }
            }
        }

        static int CalculateSumOfEvenNegatveElementsOfRow(int indexOfRow)
        {
            int sumOfEvenNegatveElementsOfRow = 0;

            for (var currentIndexInColumn = 0; currentIndexInColumn < numberOfColumnMatrix; currentIndexInColumn++)
            {
                if ((matrix[indexOfRow, currentIndexInColumn] < 0) && (matrix[indexOfRow, currentIndexInColumn] % 2 == 0))
                {
                    sumOfEvenNegatveElementsOfRow += matrix[indexOfRow, currentIndexInColumn];
                }
            }

            return sumOfEvenNegatveElementsOfRow;
        }

        /// Sort by the sum of negative even elements of row
        static void SortBySpecialParametr()
        {
            for (var currentIndexInRow_i = 0; currentIndexInRow_i < numberOfRowsMatrix; currentIndexInRow_i++)
            {
                for (var currentIndexInRow_j = currentIndexInRow_i; currentIndexInRow_j > 0; currentIndexInRow_j--)
                {
                    if (CalculateSumOfEvenNegatveElementsOfRow(currentIndexInRow_j)
                        < CalculateSumOfEvenNegatveElementsOfRow(currentIndexInRow_j - 1))
                    {
                        for (var currentIndexInColumn = 0; currentIndexInColumn
                            < numberOfColumnMatrix; currentIndexInColumn++)
                        {
                            int variableForSwappingItems = matrix[currentIndexInRow_j, currentIndexInColumn];
                            matrix[currentIndexInRow_j, currentIndexInColumn] = matrix[currentIndexInRow_j - 1, currentIndexInColumn];
                            matrix[currentIndexInRow_j - 1, currentIndexInColumn] = variableForSwappingItems;
                        }
                    }
                    else break;
                }
            }
        }
    }
}
