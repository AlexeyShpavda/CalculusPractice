using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;

            Console.WriteLine("Enter sentence:");
            sentence = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Reverse sentence:");
            for (var symbolIndex = sentence.Length - 1; symbolIndex >= 0; symbolIndex--)
            {
                Console.Write(sentence[symbolIndex]);
            }

            Console.ReadKey();
        }
    }
}
