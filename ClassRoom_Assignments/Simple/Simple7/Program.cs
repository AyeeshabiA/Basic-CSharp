

using System;
namespace Simple7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            int x=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y=int.Parse(Console.ReadLine());
            double answer=Math.Pow(x,y);
            Console.WriteLine("Answer= "+answer);
        }
    }
}