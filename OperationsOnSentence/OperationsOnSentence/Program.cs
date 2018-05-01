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

            // T1
            Console.WriteLine(initialSentence);
            Console.WriteLine(Sentence.reverseSentence(initialSentence));

            // T2
            Console.WriteLine(initialSentence);
            Console.WriteLine(Sentence.swapFirstAndLastWord(initialSentence));

            Console.ReadKey();
        }
    }
}
