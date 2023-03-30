using System;
namespace While6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = 1;
            Console.WriteLine("Even numbers: ");
            while(number<=100)
            {
                if(number%2==0)
                {
                    Console.WriteLine(number);
                   

                }
                 number++;
            }
            number = 1;
            Console.WriteLine("Odd numbers: ");
            while(number<=100)
            {
                if(number%2!=0)
                {
                    Console.WriteLine(number);
                    
                    
                }
                number++;
            }

            Console.WriteLine("Prime numbers: ");
           
            number = 2;
            
            while (number <= 100)
            {
               int count = 0;
                int number1 = 2;
                while (number1 <= number / 2)
                {
                    if (number % number1 == 0)
                    {
                        count++;
                        break;
                    }
                    number1++;
                }
                if (count == 0 && number != 1)
                {
                    Console.WriteLine(number);
                }
                number++;
            }

        }

    }
}
