using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Number of terms");
            int number = int.Parse(Console.ReadLine());
            int sum=0,number1=1;
            for(int i=0;i<number;i++)
            {
                sum+=number1;
                number1=number1*10+1;
            }
            System.Console.WriteLine("Anser: "+sum);
        }
    }
}