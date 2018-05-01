using System;
using OperationsOnSentence.Models;

namespace OperationsOnSentence
{
    class Program
    {
        static void Main()
        {
            string initialSentence;
            string line = "=================================================";

            Console.WriteLine("Enter sentence:");
            initialSentence = Convert.ToString(Console.ReadLine());
            Console.WriteLine(line);

            // T1
            Console.WriteLine(initialSentence);
            Console.WriteLine(Sentence.reverseSentence(initialSentence));
            Console.WriteLine(line);

            // T2
            Console.WriteLine(initialSentence);
            Console.WriteLine(Sentence.swapFirstAndLastWord(initialSentence));
            Console.WriteLine(line);

            // T3
            Console.WriteLine(initialSentence);
            Console.WriteLine(Sentence.glueSecondAndThirdWordsInSentence(initialSentence));
            Console.WriteLine(line);

            Console.ReadKey();
        }
    }
}
