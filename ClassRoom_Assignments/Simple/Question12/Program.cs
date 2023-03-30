using System;
namespace Question12
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter date as (dd/MM/yyyy): ");
            DateTime date=DateTime.Parse(Console.ReadLine());
            Console.WriteLine(date.DayOfWeek);
        }
    }
}