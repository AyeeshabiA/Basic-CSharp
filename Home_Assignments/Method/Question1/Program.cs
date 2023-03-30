using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("add: "+Add(15,16));
        }
        static int Add(int number1,int number2)
        {
            int sum=number1+number2;
            return sum;
        }
    }
}