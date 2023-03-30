using System;
namespace Medium3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter number: ");
            int number=int.Parse(Console.ReadLine());
            for(i=1;i<=number;i++)
            {
                if(i%4==0)
                {
                    Console.WriteLine(i+" ");
                }
            }
        }
    }
}