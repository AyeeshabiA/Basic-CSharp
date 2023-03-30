using System;
namespace While8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number1=-1,number2=1,number3;
            
            System.Console.WriteLine("Enter number tp repeat: ");
            int repeat=int.Parse(Console.ReadLine());
            while(number1<=repeat)
            {
                System.Console.WriteLine(number3=number1+number2);
                number1=number2;
                number2=number3;
            }
        }
    }
}