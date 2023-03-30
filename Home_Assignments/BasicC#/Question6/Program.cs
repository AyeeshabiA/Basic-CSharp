using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {   
            //Parse method
            Console.WriteLine("Enter price: ");
            int price=int.Parse(Console.ReadLine());
            float ans=((float)price/100)*18;
            
            Console.WriteLine("Total= "+(ans+price));
        }
    }
}


