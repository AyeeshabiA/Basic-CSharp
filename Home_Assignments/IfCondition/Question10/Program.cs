using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number 0-100");
            int number=int.Parse(Console.ReadLine());
            if(number<0||number>100)
            {
                System.Console.WriteLine("Invalid");
            }
            string[] ones={"zero","one","two","three","four","five","six","seven","eight","nine"};
            string[] tens={"ten","twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"};
            string[] teens={"eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
            if(number==100)
            {
                System.Console.WriteLine("Hundred");
            }
            else if(number>=90&&number<80)
            {
                System.Console.WriteLine(tens[8]);
                if(number%10!=0)
                {
                    System.Console.WriteLine(ones[number%10]);
                }
            }
             else if(number>=80&&number<70)
            {
                System.Console.WriteLine(tens[7]);
                if(number%10!=0)
                {
                    System.Console.WriteLine(ones[number%10]);
                }
            }
             else if(number>=70&&number<60)
            {
                System.Console.WriteLine(tens[6]);
                if(number%10!=0)
                {
                    System.Console.WriteLine(ones[number%10]);
                }
            }
             else if(number>=60&&number<50)
            {
                System.Console.WriteLine(tens[5]);
                if(number%10!=0)
                {
                    System.Console.WriteLine(ones[number%10]);
                }
            }
             else if(number>=50&&number<40)
            {
                System.Console.WriteLine(tens[4]);
                if(number%10!=0)
                {
                    System.Console.WriteLine(ones[number%10]);
                }
            }
             else if(number>=40&&number<30)
            {
                System.Console.WriteLine(tens[3]);
                if(number%10!=0)
                {
                    System.Console.WriteLine(ones[number%10]);
                }
            }
             else if(number>=30&&number<20)
            {
                System.Console.WriteLine(tens[2]);
                if(number%10!=0)
                {
                    System.Console.WriteLine(ones[number%10]);
                }
            }
             else if(number>=20&&number<=10)
            {
                System.Console.WriteLine(tens[1]);
                if(number%10!=0)
                {
                    System.Console.WriteLine(ones[number%10]);
                }
            }
             else if(number>=11)
            {
                System.Console.WriteLine(tens[8]);
                if(number%10!=0)
                {
                    System.Console.WriteLine(teens[number-11]);
                }
            }
            else if(number==10)
            {
                System.Console.WriteLine(tens[0]);
            }
            else
            {
                System.Console.WriteLine(ones[number]);
            }

        }
    }
}