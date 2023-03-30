using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            for(int i=1994;i<=2023;i++)
            {
                if(DateTime.IsLeapYear(i))
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}