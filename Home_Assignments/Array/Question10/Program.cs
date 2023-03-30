using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter row and col: ");
            int row=int.Parse(Console.ReadLine());
            int col=int.Parse(Console.ReadLine());
            int [,] matrix = new int [row,col];
            int [,] transpose=new int[col,row];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    System.Console.WriteLine("Element[{0},{1}]=",i,j);
                    matrix[i,j]=int.Parse(Console.ReadLine());
                }
            }
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    System.Console.WriteLine(matrix[i,j]+" ");
                }
                System.Console.WriteLine();
            }
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    transpose[j,i]=matrix[i,j];
                }
                System.Console.WriteLine();
            }
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    System.Console.WriteLine(transpose[j,i]+" ");
                }
                System.Console.WriteLine();
            }

        }
    }
}