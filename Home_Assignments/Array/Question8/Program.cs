using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter size: ");
            int size=int.Parse(Console.ReadLine());
            int[,]mat1=new int[size,size];
            int[,]mat2=new int[size,size];
            Console.WriteLine("element in 1st mat: ");
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size;j++)
                {
                    Console.WriteLine($"elements{0},{1}: ",i,j);
                    mat1[i,j]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("element in 2nd mat: ");
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size;j++)
                {
                    Console.WriteLine($"elements{0},{1}: ",i,j);
                    mat2[i,j]=int.Parse(Console.ReadLine());
                }
            }
            int [,] answer=new int[size,size];
            for(int i=0;i<size;i++)
            {
            for(int j=0;j<size;j++)
            {
                answer[i,j]=mat1[i,j]+mat2[i,j];
            }
            }
            for(int i=0;i<size;i++)
            {
            for(int j=0;j<size;j++)
            {
                Console.WriteLine("{0}\t",answer[i,j]);
            }
            Console.WriteLine();
            }




        }
    }
}