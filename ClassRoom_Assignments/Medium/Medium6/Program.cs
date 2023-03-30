using System;
namespace Medium6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("number of row");
            int row=int.Parse(Console.ReadLine());
              System.Console.WriteLine("number of col");
            int col=int.Parse(Console.ReadLine());
            for(int i=1;i<=row;i++)
            {
                for(int j=1;j<=col;j++)
                {
                    if(i==1||i==row||j==1||j==col)
                    {
                        System.Console.Write("*");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}