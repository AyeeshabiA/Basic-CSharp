using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("temperature:");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature < 0)
            {
                Console.WriteLine("Freezing Weather");
            }
            else if (temperature >= 0 && temperature <= 10)
            {
                Console.WriteLine("very cold");

            }
             else if (temperature > 10 && temperature <= 20)
            {
                Console.WriteLine("cold weather");

            }
             else if (temperature >20 && temperature <= 30)
            {
                Console.WriteLine(" normal temperature");

            }
             else if (temperature >30 && temperature <= 40)
            {
                Console.WriteLine("Hot");

            }
            else
            {
                System.Console.WriteLine("very hot");
            }
        }

    }
}
