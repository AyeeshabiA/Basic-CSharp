using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter elements: ");
            int number=int.Parse(Console.ReadLine());
            int[]array=new int[number];
            int[]odd=new int[number];
            int[]even=new int[number];
            int oddIndex=0,evenIndex=0,i;
            
            for(i=0;i<number;i++)
            {
                Console.WriteLine($"enetr element{i}= ");
                array[i]=int.Parse(Console.ReadLine());

            }
            foreach(int numbers in array)
            {
                if(numbers%2==0)
                {
                    even[evenIndex++]=numbers;
                }
                else{
                    odd[oddIndex++]=numbers;
                }
            }
            for(i=0;i<evenIndex;i++)
            {
                Console.WriteLine(even[i]);
            }
            Console.WriteLine();
            for(i=0;i<oddIndex;i++)
            {
                Console.WriteLine(odd[i]);
            }


        }
    }
}