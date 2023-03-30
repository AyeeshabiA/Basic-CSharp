using System;
namespace While1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of integers: ");
            int integer=int.Parse(Console.ReadLine());
            int i=1, sum=0;
            while(integer!=0)
            {
                
                Console.WriteLine($"Enter {i} number: ");
                int number=int.Parse(Console.ReadLine());
                i++;
                sum=sum+number;
                integer--;
            }
            Console.WriteLine("Sum= "+sum);
        }
    }
}
