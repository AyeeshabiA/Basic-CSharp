using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num,sum=0;
            System.Console.WriteLine("Enter number");
            num=int.Parse(Console.ReadLine());
            do
            {
                sum+=num%10;
                num/=10;
            }while(num>0);
            System.Console.WriteLine("sum: "+sum);
        }
    }
}