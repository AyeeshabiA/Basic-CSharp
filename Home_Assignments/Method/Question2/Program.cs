using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string word=Console.ReadLine();
            string[]word1=word.Split(" ");
            int answer=word1.Length-1;
            Console.WriteLine("answer= "+answer);
        }
    }
}