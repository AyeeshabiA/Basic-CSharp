using System;
namespace While2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
            Console.WriteLine("Do you want continue: ");
            string option = Console.ReadLine();
            while (option == "yes")
            {
                Console.WriteLine("Welcome " + name);
                Console.WriteLine("Do you want continue: ");
                option=Console.ReadLine();
            }
        }
    }
}
