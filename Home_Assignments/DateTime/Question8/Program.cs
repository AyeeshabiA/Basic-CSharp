using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter date: ");
            DateTime date=DateTime.Parse(Console.ReadLine());
            string longDate=date.ToLongDateString();
            Console.WriteLine(longDate);
        }
    }
}