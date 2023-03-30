using System;
namespace Question11
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number=int.Parse(Console.ReadLine());
            if(number==1||number==2)
            {
                Console.WriteLine("It is prime");
            }
            else if(number%2==0)
            {
                 Console.WriteLine("It is not a prime");
            }
            else
            {
                int flag=1;
                for(int i=3;i<=number/2;i++)
                {
                    if(number%i==0)
                    {
                    flag=0;
                    Console.WriteLine("It is not a prime");
                    }
                }
                if(flag==1)
                {
                    Console.WriteLine("It is prime"); 
                }
            }
        }
    }
}