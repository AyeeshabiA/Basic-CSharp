using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num;
            do
            {
                System.Console.WriteLine("Enter number");
                num=int.Parse(Console.ReadLine());
            }while(num==0);
            for(int i=1;i<=10;i++)
            {
                System.Console.WriteLine("{0}*{1}={2}",num,i,num*i);
            }
        }
    }
}