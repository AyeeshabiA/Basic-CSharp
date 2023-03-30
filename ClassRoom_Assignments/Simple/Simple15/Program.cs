using System;
namespace Simple15
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string name=Console.ReadLine();
            welcomeName(name);
            wish();
        }
        static void welcomeName(string name)
        {
            Console.WriteLine("Welcome "+name);
        }
        static void wish()
        {
            Console.WriteLine("Have a nice day");
        }
    }
}
