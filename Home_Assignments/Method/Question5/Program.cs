using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter number: ");
            int number=int.Parse(Console.ReadLine());
            PrimeNumber(number);
        }
        static void PrimeNumber(int number)
        {
            int count=0,i;
            for(i=0;i<=number/2;i++)
            {
                if(number%i==0)
                {
                    count++;
                }
            }
                if(count==2)
                {
                    Console.WriteLine("It is prime");
                }
                else
                {
                    Console.WriteLine("It is not prime");
                }
            }

        
    }
}