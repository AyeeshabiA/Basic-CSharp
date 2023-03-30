using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter character: ");
            char word=char.Parse(Console.ReadLine());
            switch(word)
            {
                case 'a':
                {
                    Console.WriteLine("It is vowel");
                    break;
                }
                case 'e':
                {
                    Console.WriteLine("It is vowel");
                    break;
                }
                case 'i':
                {
                    Console.WriteLine("It is vowel");
                    break;
                }
                case 'o':
                {
                    Console.WriteLine("It is vowel");
                    break;
                }
                case 'u':
                {
                    Console.WriteLine("It is vowel");
                    break;
                }
                default:
                {
                     Console.WriteLine("It is not a vowel");
                    break;
               
                }
            }

        }
    }
}