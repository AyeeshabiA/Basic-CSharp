using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, s=0;
            for(i=1;i<=99;i++)
            {
                if(i%2!=0)
                {
                    s=s+i*i;
                }
            }
            Console.WriteLine("Sum of square of odd values between 1-99 is: "+s);
        }
    }
}
