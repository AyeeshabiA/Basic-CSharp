using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter mark1: ");
            int mark1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter mark2: ");
            int mark2=int.Parse(Console.ReadLine());
            Console.WriteLine("enter mark3: ");
            int mark3=int.Parse(Console.ReadLine());
            double percentage=Percentage(mark1,mark2,mark3);
            Console.WriteLine("percentage: "+percentage);
        }
        static double Percentage(int mark1,int mark2,int mark3)
        {
            int total=300;
            int mark=mark1+mark2+mark3;
            double percentage=(mark+100)/total;
            return percentage;
        }
    }
}