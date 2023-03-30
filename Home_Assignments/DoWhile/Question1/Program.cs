using System;
namespace DoWhile1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string option;
            do
            {
                Console.WriteLine("Enter the number: ");
                int number=int.Parse(Console.ReadLine());
                if(number%2==0)
                {
                    Console.WriteLine("It is even");
                }
                else{
                    Console.WriteLine("It is odd");
                }
                Console.WriteLine("Enter to continue yes otherwise no: ");
                option=Console.ReadLine();
            }while(option=="yes");
        }
    }
}