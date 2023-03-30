using System;
namespace Medium10
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter string");
            string word=Console.ReadLine();
            System.Console.WriteLine("Alphabet:"+Alphabet(word));
            System.Console.WriteLine("Digit:"+Digit(word));
            System.Console.WriteLine("Special char:"+Character(word));

        }
        static int Alphabet(string word)
        {
            int c=0;
            foreach(char words in word)
            {
                if(char.IsLetter(words))
                {
                    c++;
                }
            }
            return c;
        }
        static  int Digit(string word)
        {
            int c=0;
            foreach(char words in word)
            {
                if(char.IsDigit(words))
                {
                    c++;
                }
            }
            return c;
        }
         static  int Character(string word)
        {
            int c=0;
            foreach(char words in word)
            {
                if(!char.IsLetterOrDigit(words)&&!char.IsWhiteSpace(words))
                {
                    c++;
                }
            }
            return c;
        }
    }
}