using System;
namespace While10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number=int.Parse(Console.ReadLine());
            int sum=0;
            int number1;
            while(number>0)
            {
                number1=number*number;
                sum=sum+number1;
                number--;
            }
            Console.WriteLine(sum);
        }
    }
}
