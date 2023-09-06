using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeFRFR
{
    class Program
    {
        static void Main(string[] args)
        {
        // Palindrome
            Console.Write("Enter any word: ");
            string word = Console.ReadLine();

            //remove spaces
            word = word.Replace(" ", "");

            //convert any uppercase to lowercase
            string result = word.ToLower();

            //holds the value of reverted word
            string transfer = "";

            //you need a for loop to reverse the word

            for(int i = result.Length-1; i > -1; i--)
            {
                transfer += result[i];
            }
            Console.WriteLine(transfer);
            if (transfer.Equals(result))
            {
                Console.WriteLine("This is a palindrome");
            }
            else
            {
                Console.WriteLine("This ain't palindrome homie");
            }
        }
    }
}
