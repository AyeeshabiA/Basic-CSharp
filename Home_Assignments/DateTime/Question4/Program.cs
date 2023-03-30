using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter date: ");
            DateTime date=DateTime.Parse(Console.ReadLine());
            Console.WriteLine(date.AddYears(15));
            Console.WriteLine(date.AddYears(-15));

        }
    }
}