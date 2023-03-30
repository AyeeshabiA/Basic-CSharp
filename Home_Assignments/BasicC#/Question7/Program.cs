using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {   
            //Parse method
            Console.WriteLine("Enter speed: ");
            int speed=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time: ");
            int time=int.Parse(Console.ReadLine());
            Console.WriteLine("Meters= "+(speed*time*5/18));
            

            

        }
    }
}


