using System;

namespace CoderByte
{
  
    internal class Program
    {
        public static string StringChallenge(string str)
        {
            int countVowels = 0;
            string[] vowels = new string[] { "a", "i", "e", "o", "u" };
            foreach (var item in vowels)
            {
                if (str.Contains(item))
                {
                    countVowels++;
                }
            }
            // code goes here  
            return countVowels.ToString();

        }
        static void Main(string[] args)
        {
            var Show = StringChallenge("Hello everyone I am programmer");
            Console.WriteLine(Show);
            Console.WriteLine("Hello World!");
        }
    }
}
