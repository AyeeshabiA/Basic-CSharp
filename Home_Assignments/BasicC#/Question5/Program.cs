using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {   
            //Parse method
            Console.WriteLine("Enter two digit number: ");
            int number=int.Parse(Console.ReadLine());
            int number1=(number/10);
            int number2=(number%10);
            Console.WriteLine((number1+number2));
            


            

        }
    }
}

