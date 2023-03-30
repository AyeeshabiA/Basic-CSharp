using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter number1: ");
            int number1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter number2: ");
            int number2=int.Parse(Console.ReadLine());
            swap(number1,number2);

        }
        static void swap(int number1,int number2)
        {
            int temp;
            temp=number1;
            number1=number2;
            number2=temp;

            Console.Write("number1: "+number1);
             Console.Write("number2: "+number2);

        }
    }
}