using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("number: ");
            int number=int.Parse(Console.ReadLine());
            if(number>=0)
            {
                Console.WriteLine(number+"positive");
            }
            else
            {
                Console.WriteLine(number+"negative");
            }
        }
    }
}
