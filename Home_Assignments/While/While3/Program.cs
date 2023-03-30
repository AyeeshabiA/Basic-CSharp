using System;
namespace While3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number=int.Parse(Console.ReadLine());
            int initialValue=1;
            while(initialValue<=number)
            {
                if(initialValue%5==0)
                {
                    Console.WriteLine(initialValue);
                }
                initialValue++;
            }
        }
    }
}
