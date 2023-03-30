using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number1: ");
            int number1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2: ");
            int number2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter options: ");
            Console.WriteLine("Enter 1 for Addition\nEnter 2 for Subtraction\nEnter 3 for Multiplication\nEnter 4 for Division\nEnter 5 for Exit: ");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine("Addition= "+(number1+number2));
                    break;
                }
                 case 2:
                {
                    Console.WriteLine("Subtraction= "+(number1-number2));
                    break;
                }
                 case 3:
                {
                    Console.WriteLine("Multiplication= "+(number1*number2));
                    break;
                }
                 case 4:
                {
                    Console.WriteLine("Division= "+(number1/number2));
                    break;
                }
                case 5:
                {
                    
                    break;
                }
                
            }
            
        }
    }
}


