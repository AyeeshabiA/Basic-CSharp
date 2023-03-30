using System;
namespace While4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number=int.Parse(Console.ReadLine());
            int remainder;
            int sum=0;
            while(number!=0)
            {
                remainder=number%10;
                sum=sum*10+remainder;
                number=number/10;
            }
            Console.WriteLine("The number is: "+sum);
        }
    }
}
