using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number");
            int number=int.Parse(Console.ReadLine());
            System.Console.Write("1");
            double sum=0;
            for(int i=2;i<=number;i++)
            {
                System.Console.Write("+1/{0}",i);
                sum+=1.0/i;
            }
            System.Console.WriteLine("sum: "+sum);
        }
    }
}