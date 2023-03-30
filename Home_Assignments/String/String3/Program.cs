using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter string");
            string word=Console.ReadLine();
            char[] array=word.ToCharArray();
            foreach(char charac in array)
            {
                Console.Write(charac+" ");
            }
        }
    }
}