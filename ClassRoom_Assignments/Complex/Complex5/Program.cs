using System;
namespace Complex5
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime today=DateTime.Now;
            //DateTime dob=new DateTime(2001,08,31);
            Console.WriteLine("Enter date in this format(dd,MM,yyyy) ");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd,MM,yyyy",null);

            TimeSpan span=today-dob;
            int age=span.Days/365;	
            Console.WriteLine("age"+age);
            Console.WriteLine("Day you were born was "+dob.DayOfWeek);
            Console.Write("days:"+ (int)span.TotalDays);
            Console.Write("Hours:"+ span.Hours);
            Console.Write("Minutes:"+ span.Minutes);
            Console.Write("Seconds:"+ span.Seconds);
            Console.Write("Milliseconds:"+ (span.Milliseconds));
            	


        }
    }
}

