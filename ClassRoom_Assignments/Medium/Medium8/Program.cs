using System;
namespace Medium8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i,factorial=1;
            Console.WriteLine("Enter number: ");
            int number=int.Parse(Console.ReadLine());
            for(i=1;i<=number;i++)
            {
                factorial=factorial*i;
               
            }
            Console.WriteLine("Factorial= :"+factorial);
        }
    }
}
