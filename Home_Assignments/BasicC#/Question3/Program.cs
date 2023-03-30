using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {   
            //Parse method
            Console.WriteLine("Enter celsius: ");
            int celsius=int.Parse(Console.ReadLine());
            double output=((celsius*(double)9/5)+32);
            Console.WriteLine("Fahrenheit= "+output);
            Console.WriteLine("kelvin= "+(celsius+273.15));


            

        }
    }
}

