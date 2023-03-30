using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter value: ");
            int value1=int.Parse(Console.ReadLine());
            bool result=bool.Parse(value1==15?"true":"false");
            Console.WriteLine(result);
            Console.WriteLine("Enter value: ");
            int value2=int.Parse(Console.ReadLine());
            bool result1=bool.Parse(value2<=5?"true":"false");
            Console.WriteLine(result1);
        }
    }
}
