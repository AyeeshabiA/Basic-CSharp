using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number");
            int input=int.Parse(Console.ReadLine());
            double sum=0;
            for(int i=0;i<=input;i++)
            {
                sum+=i*i*i;
                System.Console.WriteLine("Answer: "+sum);
            }
        }
    }
}