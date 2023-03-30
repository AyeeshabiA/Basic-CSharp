using System;
namespace Question15
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string name=Console.ReadLine();
            string welcome(name);
        }
         public string welcome(name)
        {
            Console.WriteLine("Welcome "+name);
        }
    }
}
