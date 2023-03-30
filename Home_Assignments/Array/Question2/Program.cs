using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int [] element=new int[];
            Console.WriteLine("Enter number of element:");
            int number=int.Parse(Console.ReadLine());
            for(int i=0;i<number;i++)
            {
                Console.WriteLine($"Enter{i+1}element: ");
                string element[i]=(Console.ReadLine());
            }
            Array.Reverse(element);
            foreach(int elements in element)
            {
                Console.WriteLine(elements);
            }
        }
    }
}
