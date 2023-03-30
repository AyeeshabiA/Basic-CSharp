using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int [] number=new int[10];
            int sum=0;
            System.Console.WriteLine("Enter number");
            for(int i=0;i<10;i++)
            {
                System.Console.WriteLine($"Number: {i+1}");
                number[i]=int.Parse(Console.ReadLine());
                sum+=number[i];
            }
            double avg=(double)sum/10.0;
            System.Console.WriteLine($"Sum:{sum}\nAvg:{avg}");
        }
    }
}