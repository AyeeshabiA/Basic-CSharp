using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Month number: ");
            int number=int.Parse(Console.ReadLine());
            switch(number)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                {
                    Console.WriteLine("Month have 31 days");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Month have 28 days");
                    break;
                }
                case 4:
                case 6:
                case 9:
                case 11:
                {
                    Console.WriteLine("Month have 30 days");
                    break;
                }

            }
            
        }
    }
}


