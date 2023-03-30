using System;
namespace String4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter string");;
            string word=Console.ReadLine();
            string[]words=word.Split(" ");
            int count=0;
            for(int i=0;i<words.Length;i++)
            {
                System.Console.WriteLine(words[i]);
                count++;
            }
            System.Console.WriteLine();
        }
    }
}