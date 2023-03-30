using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int [,] matrices=new int[3,3];
            Console.WriteLine("enter elements: ");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write($"elements{i}{j}: ");
                    matrices[i,j]=int.Parse(Console.ReadLine());
                }
            }
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(matrices[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}