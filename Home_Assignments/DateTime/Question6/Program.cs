using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("ENTER DATE: ");
            DateTime date=DateTime.Parse(Console.ReadLine());
            DateTime date1=DateTime.Today;
            int answer=DateTime.Compare(date,date1);
            if(answer<0)
            {
                Console.WriteLine(date+ "is past");
            }
            else if(answer==0)
            {
                Console.WriteLine(date+ "is present");
            }
            else
            {
                Console.WriteLine(date+ "is future");
            }
        }
    }
}