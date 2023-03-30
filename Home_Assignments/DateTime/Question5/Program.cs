using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime date=DateTime.Now;
            Console.Write(date.AddYears(1));
             Console.Write(date.AddYears(-1));
        }
    }
}