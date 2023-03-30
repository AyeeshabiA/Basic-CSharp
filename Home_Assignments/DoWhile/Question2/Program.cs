using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int count,number,sum=0;
            int temp=0;
            System.Console.WriteLine("Enter number of count");
            count=int.Parse(Console.ReadLine());
            do
            {
                System.Console.WriteLine("Enter number");
                number=int.Parse(Console.ReadLine());
                if(number>0)
                {
                    sum+=number;
                }
                temp++;
            }while(temp<count);
            System.Console.WriteLine("sum: "+sum);
        }
    }
}