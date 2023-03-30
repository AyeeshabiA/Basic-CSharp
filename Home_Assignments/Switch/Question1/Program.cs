using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter grade: ");
            char grade=char.Parse(Console.ReadLine());
            switch(grade)
            {
                case 'A':
                {
                    Console.WriteLine("Average");
                    break;
                }
                case 'G':
                {
                    Console.WriteLine("Good");
                    break;
                }
                case 'E':
                {
                    Console.WriteLine("Excellent");
                    break;
                }
                case 'V':
                {
                    Console.WriteLine("Very Good");
                    break;
                }
                case 'F':
                {
                    Console.WriteLine("Fail");
                    break;
                }
                default:
                {
                     Console.WriteLine("Operation invalid");
                    break;
                }
            }
            
        }
    }
}

