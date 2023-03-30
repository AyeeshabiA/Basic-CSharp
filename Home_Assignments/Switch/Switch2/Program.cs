using System;
namespace Switch2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string result;
            Console.WriteLine("Enter number: ");
            int number=int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                result="even";
            }
            else
            {
                result="odd";
            }
            switch(result)
            {
                case "even":
                {
                    Console.WriteLine("It is even number");
                    break;
                }
                case "odd":
                {
                    Console.WriteLine("It is odd number");
                    break;
                }
            }
        }

        
    }
}