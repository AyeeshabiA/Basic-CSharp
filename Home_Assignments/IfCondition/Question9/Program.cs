using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("number1: ");
            int number1=int.Parse (Console.ReadLine());
            
            System.Console.WriteLine("number2: ");
            int number2=int.Parse (Console.ReadLine());
            
            System.Console.WriteLine("number3: ");
            int number3=int.Parse (Console.ReadLine());
            if(number1>number2&&number1>number3)
            {
                System.Console.WriteLine("Number 1 is large ");
            }
            else if(number2>number1&&number2>number3)
            {
                System.Console.WriteLine("Number 2 is large ");
            }
            else 
            {
                System.Console.WriteLine("Number 3 is large ");
            }
            
        }
    }
}