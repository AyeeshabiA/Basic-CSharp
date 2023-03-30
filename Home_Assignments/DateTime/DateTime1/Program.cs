using System;
namespace DateTime1
{
    class Program
    {
        public static void Main(string[] args)
        {

            DateTime today = DateTime.Now;
            Console.WriteLine("year= "+today.Year);
            Console.WriteLine("Month= "+today.Month);
            Console.WriteLine("Date= "+today.Date);
            Console.WriteLine("Hour= "+today.Hour);
            Console.WriteLine("Minute= "+today.Minute);
            Console.WriteLine("Second= "+today.Second);
            Console.WriteLine("Millisecond= "+today.Millisecond);
        }
    }
}
