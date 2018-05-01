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

        public static string glueWordsInSentence(string sentence, int indexFrom, int indexTo)
        {
            string initialSentence = sentence;
            int startIndex = indexFrom;
            int finishIndex = indexTo;

            string[] words;
            words = initialSentence.Split(' ');

            string newSentence = String.Empty;
            int wordCounter = 1;
            foreach (var word in words)
            {
                newSentence += word;
                if (wordCounter < startIndex || wordCounter >= finishIndex)
                {
                    newSentence += " ";
                }
                wordCounter++;
            }

            return newSentence;
        }

        public static string reverseWord(string sentence, int index)
        {
            string initialSentence = sentence;
            int wordIndex = index;

            string[] words;
            words = initialSentence.Split(' ');

            string word = String.Empty;
            for (var symbolIndex = words[index].Length - 1; symbolIndex >= 0; symbolIndex--)
            {
                word += words[index][symbolIndex];
            }

            return word;
        }
    }
}
