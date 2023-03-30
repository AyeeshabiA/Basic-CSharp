using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i,s=0;
            Console.WriteLine("Number= ");
            int number=int.Parse(Console.ReadLine());
           for(i=1;i<=number;i++)
           {
               s=s+i;
           }
           Console.WriteLine("The sum is "+s);
        }
    }
}


