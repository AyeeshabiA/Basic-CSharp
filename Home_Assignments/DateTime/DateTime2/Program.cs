using System;
namespace DateTime2
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime today=DateTime.Now;
            Console.WriteLine("today: "+today);
            DateTime newDay=today.AddDays(40);
            Console.WriteLine("Adding 40 days after the day is: "+newDay.DayOfWeek);
        }
    }
}
