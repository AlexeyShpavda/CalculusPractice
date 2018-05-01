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
            Console.WriteLine(Sentence.glueWordsInSentence(initialSentence, 2, 3));
            Console.WriteLine(line);

            // T4
            Console.WriteLine(initialSentence);
            Console.WriteLine(Sentence.reverseWord(initialSentence, 2));
            Console.WriteLine(line);

            // T5
            Console.WriteLine(initialSentence);
            Console.WriteLine(Sentence.cutOutFirstTwoLetters(initialSentence, 0));
            Console.WriteLine(line);


            Console.ReadKey();
        }
    }
}
