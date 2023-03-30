using System;
namespace Medium9
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Enter date in this format(dd/MM/yyyy)");
            DateTime date=DateTime.Parse(Console.ReadLine());
           System.Console.WriteLine("NUMBER OF MONTH");
           int month=int.Parse(Console.ReadLine());
           Calculate(date,month);

        }
        static void Calculate(DateTime date,int month)
        {
            DateTime Calculation=date.AddMonths(month);
            System.Console.WriteLine(Calculation);
        }
    }
}

