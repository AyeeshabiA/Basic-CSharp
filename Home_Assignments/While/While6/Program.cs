using System;
namespace While5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter how many number to add: ");
            int count=int.Parse(Console.ReadLine());
            int sum=0;
            while(count!=0)
            {
                Console.WriteLine("Enter a number: ");
                int number=int.Parse(Console.ReadLine());
                sum=sum+number;
                count--;
            }
            Console.WriteLine("sum: "+sum);
        }
    }
}
