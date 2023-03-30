using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter no. of element: ");
            int number=int.Parse(Console.ReadLine());
            int []array=new int[number];
            int sum=0,i;
            for(i=0;i<number;i++)
            {
                Console.WriteLine($"enter element(i)= ");
                array[i]=int.Parse(Console.ReadLine());

            }
            foreach(int numbers in array)
            {
                sum+=numbers;
            }
            Console.WriteLine("sum= "+sum);
        }
    }
}