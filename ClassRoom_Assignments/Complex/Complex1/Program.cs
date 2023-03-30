using System;
namespace Complex1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int [,] matrix1={{1,2,3},{4,5,6}};
            int [,] matrix2={{7,8},{9,10},{11,12}};
            int row1=matrix1.GetLength(0);
             int col1=matrix1.GetLength(1);
              int row2=matrix2.GetLength(0);
               int col2=matrix2.GetLength(1);
               if(col1!=row2)
               {
                System.Console.WriteLine("Can't multiply");
               }
               else
               {
                int [,] result = new int[row1,col2];
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
                    for(int j=0;j<col2;j++)
                    {
                        System.Console.Write(result[i,j]+"\t");
                    }
                    System.Console.WriteLine();
                }
               }

        }
    }
}