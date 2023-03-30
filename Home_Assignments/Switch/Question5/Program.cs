using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(("Enter character"));
            char charc=char.Parse(Console.ReadLine().ToLower());
            switch(charc)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                {
                    System.Console.WriteLine("vowel");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("NOT ");
                    break;
                }
            }
        }
    }
}