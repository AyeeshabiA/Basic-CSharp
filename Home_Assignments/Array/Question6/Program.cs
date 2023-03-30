using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter size: ");
            int size = int.Parse(Console.ReadLine());
            int [] array=new int [size];
            for(int i=0;i<size;i++)
            {
                Console.WriteLine($"enter elements{i}: ");
                array[i]=int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine();
            foreach(int numbers in array)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}