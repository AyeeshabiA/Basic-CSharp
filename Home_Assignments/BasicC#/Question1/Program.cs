using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Enter your name: ");
            string myName = Console.ReadLine();
        
        //Concatenation
        Console.WriteLine("Hello: " +myName);
        //Placeholder
        Console.WriteLine("Hello: {0}",myName);
        //Interpolation
       Console.WriteLine($"Hello: {myName}");
        Console.ReadLine();
        }
    }
}
