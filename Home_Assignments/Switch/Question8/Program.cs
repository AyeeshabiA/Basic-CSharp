using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter month: ");
            string month=Console.ReadLine().ToLower();
            switch(month)
            {
                case "december":
                case "january":
                case "february":
                {
                    System.Console.WriteLine("Winter");
                    break;
                }
                case "march":
                case "april":
                case "may":
                {
                    System.Console.WriteLine("Spring");
                    break;
                }
                case "june":
                case "july":
                case "august":
                {
                    System.Console.WriteLine("Summer");
                    break;
                }
                case "september":
                case "october":
                case "november":
                {
                    System.Console.WriteLine("Rainfall");
                    break;
                }
            }
        }
    }
}