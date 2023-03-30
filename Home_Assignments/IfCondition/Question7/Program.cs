using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Year:");
            int year=int.Parse(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine(year+"leeap");
            }
            else{
                Console.WriteLine(year+"not leap");
            }
        }
    }
}