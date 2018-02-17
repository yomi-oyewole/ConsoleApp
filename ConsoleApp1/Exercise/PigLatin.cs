using System;


namespace ConsoleApp1.Exercise
{
    class PigLatin
    {
        static void Main(string[] args)
        {
            Console.Write("PIGLATIN GAME \nPlease enter A word: ");
            string word = Console.ReadLine();
            string wordToLower = word.ToLower();

            //error handling, enforces only alphabet input.
            foreach (var c in wordToLower)
            {
                if (!Char.IsLetter(c))
                {
                    Console.WriteLine("This app accepts only alphabetical characters \nPlease a enter valid word");
                    Console.ReadLine();
                    return;
                }
            }

            PigLatin.pigLatinGame(wordToLower);
            Console.ReadLine();
        }

        static char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };



        public static void pigLatinGame(string enteredWord)
        {
            string newWord;

            char firstChar = //EnteredWord.Substring(0, 1);
                enteredWord[0];


            char secondChar = enteredWord[1];
            char[] enteredWord2 = enteredWord.ToCharArray();
            bool checker = false;


            //Consonant clusters
            for (int i = 0; i < consonants.Length; i++)
            {

                if (consonants[i].Equals(firstChar))

                {
                    for (int k = 0; k < consonants.Length; k++)
                    {
                        if (consonants[k].Equals(secondChar))
                        {
                            newWord = enteredWord.Substring(2);
                            Console.WriteLine("Hey I found a consonant clusters: {0} and {1}", firstChar, secondChar);
                            Console.WriteLine("Original word: " + enteredWord + "\nPiglatin conversion: " + newWord + firstChar + secondChar + "ay");
                            return;
                        }
                    }
                }

            }


            foreach (var vowel in vowels)
            {
                //first vowel
                if (vowel.Equals(enteredWord[0]))
                {
                    newWord = enteredWord.Substring(1);
                    Console.WriteLine("Hey I found vowel as the first letter: {0} ", firstChar);
                    Console.WriteLine("Original word: " + enteredWord + "\nPiglatin conversion: " + newWord + firstChar + "yay");
                    checker = true;
                    return;
                }

            }
            //first consonant
            if (checker == false)
            {
                newWord = enteredWord.Substring(1);
                Console.WriteLine("Hey I found Consonant as the first letter: {0} ", firstChar);
                Console.WriteLine("Original word: " + enteredWord + "\nPiglatin conversion: " + newWord + firstChar + "ay");
            }

        }

    }
}

