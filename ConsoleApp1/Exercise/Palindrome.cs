using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exercise
{
    class Palindrome
    {
        public static void Main(string[] args)
        {
            Console.Write("PALINDROME GAME \nPlease enter a word: ");
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
            PalindromeMeth(word);
            Console.ReadLine();
        }

        public static void PalindromeMeth(string message)
        {
            string newword = "";
            string messageLower = message.ToLower();
            char[] MessagChar = messageLower.ToCharArray();
            Array.Reverse(MessagChar);
            foreach (char word in MessagChar)
            {
                newword += word;

            }
            if (newword == messageLower)
                Console.WriteLine("the word you entered is a palindrome.\nHere is the reversed version: ");
            else
                Console.WriteLine("I am sorry, the word you entered is not a palindrome.\nHere is the reversed version: ");
            Console.WriteLine(newword);
        }
    }
}
