using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(" Enter 1st row and 1st col");
            int row1=int.Parse(Console.ReadLine());
            int col1=int.Parse(Console.ReadLine());
             System.Console.WriteLine(" Enter 2nt row and 2nd col");
            int row2=int.Parse(Console.ReadLine());
            int col2=int.Parse(Console.ReadLine());
            if(col1!=row2)
            {
                System.Console.WriteLine("Can't multiply");
            }
            else
            {
                int [,]matrix1=new int[row1,col1];
                 int [,]matrix2=new int[row2,col2];
                 for(int i=0;i<row1;i++)
                 {
                    for(int j=0;j<col1;j++)
                    {
                        matrix1[i,j]=int.Parse(Console.ReadLine());
                    }
                 }
                  for(int i=0;i<row2;i++)
                 {
                    for(int j=0;j<col2;j++)
                    {
                        matrix2[i,j]=int.Parse(Console.ReadLine());
                    }
                 }
                 int [,] result=new int[row1,col2];
                  for(int i=0;i<row1;i++)
                 {
                    for(int j=0;j<col2;j++)
                    {
                        for(int k=0;k<col1;k++)
                        {
                            result[i,j]+=matrix1[i,k]*matrix2[k,j];
                        }
                    }
                 }
                 for(int i=0;i<row1;i++)
                 {
                    for(int j=0;j<col1;j++)
                    {
                        System.Console.Write(matrix1[i,j]+" ");
                    }
                 }
                 for(int i=0;i<row2;i++)
                 {
                    for(int j=0;j<col2;j++)
                    {
                        System.Console.Write(matrix2[i,j]+" ");
                    }
                 }
                 for(int i=0;i<row1;i++)
                 {
                    for(int j=0;j<col2;j++)
                    {
                        System.Console.Write(result[i,j]+" ");
                    }
                 }


            }

        }
    }
}