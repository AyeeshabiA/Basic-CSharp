using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime date=DateTime.Now;
            DateTime day=date.AddDays(40);
            Console.WriteLine(day.DayOfWeek);
        }
    }
}