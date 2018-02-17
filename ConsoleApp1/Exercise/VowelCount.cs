using System;
namespace ConsoleApp1.Exercise
{
    class VowelCount
    {
        public static void Main(string[] args)
        {

            Console.Write("VOWELCOUNT GAME \nPlease enter a word: ");
            string word = Console.ReadLine();

            foreach (var c in word)
            {
                if (!Char.IsLetter(c))
                {
                    Console.WriteLine("This app accepts only alphabetical characters \nPlease a enter valid word");
                    Console.ReadLine();
                    return;
                }
            }
            VowelCountMethod(word);
            Console.ReadLine();
        }

        static char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static void VowelCountMethod(string message)
        {
            int count = 0;
            int sum = 0;
            string messageLower = message.ToLower().Trim();
            char[] MessageToCharArray = messageLower.ToCharArray();
            foreach (char messageChar in MessageToCharArray)
            {
                foreach (var vowel in Vowels)
                {
                    if (messageChar.Equals(vowel))
                    {
                        count++;
                         sum += count;
                    }
                }

                
            }
            Console.WriteLine("There are "+ count + " vowels in " + message);
            Console.WriteLine("and the sum of the vowels is " + sum);
        }


    }
}
