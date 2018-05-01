using System;
using OperationsOnSentence.Models;

namespace OperationsOnSentence
{
    class Program
    {
        static void Main()
        {
            string initialSentence;

            Console.WriteLine("Enter sentence:");
            initialSentence = Convert.ToString(Console.ReadLine());

            string newSentence = Sentence.swapFirstAndLastWord(initialSentence);

            Console.WriteLine(initialSentence);
            Console.WriteLine(newSentence);

            Console.ReadKey();
        }
    }
}
