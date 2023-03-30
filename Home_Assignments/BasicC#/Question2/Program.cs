using System;
namespace TypeConversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Parse method
            Console.WriteLine("Enter number1: ");
            int number1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2: ");
            int number2=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Addition= "+(number1+number2));
            System.Console.WriteLine("Subtraction= "+(number1-number2));
            System.Console.WriteLine("Multiplication= "+(number1*number2));
            double output=(double)number1/number2;
            Console.WriteLine("Division= "+output);
            

        }
    }
}

