using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter table number: ");
            int number =int.Parse(Console.ReadLine());
            for(int i = 1;i<=20;i++)
            {
                int table=i*number;
                Console.WriteLine($"{number} * {i} = {table}");
            }
        }
    }
}