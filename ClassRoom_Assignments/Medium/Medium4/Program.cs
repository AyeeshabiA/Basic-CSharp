using System;
namespace Medium4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int start=int.Parse(Console.ReadLine());
             Console.WriteLine("Enter number: ");
            int end=int.Parse(Console.ReadLine());
            int i,temp;
            for(i=start;i<=end;i++)
            {
                
            double sum=0,digit,rem;
            temp=i;
                digit=i.ToString().Length;
                while(temp!=0)
                {
                    rem=temp%10;
                    sum=sum+Math.Pow(rem,digit);
                    temp=temp/10;
                }
                if(sum==i)
                {
                    Console.WriteLine(i+" ");
                }

            }
        }
    }
}