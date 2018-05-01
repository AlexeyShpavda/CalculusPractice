using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsOnSentence.Models
{
    class Sentence
    {
        public static string reverseSentence(string sentence)
        {
            string initialSentence = sentence;

            string newSentence = String.Empty;
            for (var symbolIndex = sentence.Length - 1; symbolIndex >= 0; symbolIndex--)
            {
                newSentence += sentence[symbolIndex];
            }

            return newSentence;
        }

        public static string swapFirstAndLastWord(string sentence)
        {
            string initialSentence = sentence;

            string[] words;
            words = initialSentence.Split(' ');

            int numberOfWords = words.Length;
            string swapping = words[0];
            words[0] = words[numberOfWords - 1];
            words[numberOfWords - 1] = swapping;

            string newSentence = String.Empty;
            foreach (var word in words)
            {
                newSentence += word + " ";
            }

            return newSentence;
        }
    }
}
