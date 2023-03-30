using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number1: ");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter number2: ");
            int number2=int.Parse(Console.ReadLine());
            switch(number1>number2)
            {
                case true:
                {
                    System.Console.WriteLine("Number 1 is max");
                    break;
                }
                case false:
                {
                    System.Console.WriteLine("Number 2 is max");
                    break;
                }
            }

        }
    }
}