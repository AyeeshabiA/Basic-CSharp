using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter elements: ");
            int number=int.Parse(Console.ReadLine());
            int [] array=new int [number];
            for(int i=0;i<number;i++)
            {
                Console.WriteLine($"enter elements(i)= ");
                array[i]=int.Parse(Console.ReadLine());
            }
            int maximum=array[0];
            int minimum=array[0];
            foreach(int numbers in array)
            {
                if(numbers>maximum)
                {
                    maximum=numbers;
                }
                if(numbers<minimum)
                {
                    minimum=numbers;
                }
            }
            Console.WriteLine("max= "+maximum);
            Console.WriteLine("min= "+minimum);

        }
    }
}