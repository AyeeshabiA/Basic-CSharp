using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter month: ");
            int month=int.Parse(Console.ReadLine());
            System.Console.WriteLine("enter year: ");
            int year=int.Parse(Console.ReadLine());
            int  days=DateTime.DaysInMonth(year,month);
            System.Console.WriteLine(days);
        }
    }
}