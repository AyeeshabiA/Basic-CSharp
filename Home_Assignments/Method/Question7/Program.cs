using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter number1: ");
            int number1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter number2: ");
            int number2=int.Parse(Console.ReadLine());
            Program maths=new Program();
            int add=maths.Addition(number1,number2);
              int subtract=maths.Subtraction(number1,number2);
                int multiply=maths.Multiplication(number1,number2);
                  int divide=maths.Division(number1,number2);
                  Console.WriteLine("addition= "+add);
                  Console.WriteLine("subtraction= "+subtract);
                  Console.WriteLine("multiply= "+multiply);
                  Console.WriteLine("division= "+divide);




        }
        int answer;
        public int Addition(int number1,int number2)
        {
            return answer=number1+number2;
        }
         public int Subtraction(int number1,int number2)
        {
            return answer=number1-number2;
        }
         public int Multiplication(int number1,int number2)
        {
            return answer=number1*number2;
        }
         public int Division(int number1,int number2)
        {
            return answer=number1/number2;
        }

    }
}