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
           
            while(number>0)
            {
                
                sum=sum+number;
                number--;
            }
            Console.WriteLine(sum);
        }
    }
}

