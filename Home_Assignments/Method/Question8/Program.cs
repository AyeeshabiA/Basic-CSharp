using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number=23454567;
            int index=5;
            int answer=Digit(number,index);
            Console.WriteLine($"number: "+answer);
        }
        public static int Digit(int number, int index)
        {
            
            int num=(int)Math.Log10(number)+1;
            int index1=num=index;
            int digit=(int)(number/Math.Pow(10,index1))%10;
            return digit;
        }
    }
}