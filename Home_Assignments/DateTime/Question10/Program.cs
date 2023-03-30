using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter date: ");
            DateTime date1=DateTime.Parse(Console.ReadLine());
             System.Console.WriteLine("enter date: ");
            DateTime date2=DateTime.Parse(Console.ReadLine());
            TimeSpan differ=date2-date1;
            int dayDiffer=differ.Days;
            System.Console.WriteLine(dayDiffer);

        }
    }
}