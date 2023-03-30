using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i,j,k,row=4;
            for(i=1;i<=row;i++)
            {
                for(j=1;j<=(row-i);j++)
                {
                    System.Console.Write(" ");
                }
                for(k=1;k<=i;k++)
                {
                    System.Console.Write(i);
                }
                System.Console.WriteLine();
            }
        }
    }
}