using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string correct="c";
            string user;
            string contiue;
            do
            {
                System.Console.WriteLine("What is the command keyword to exit a loop in C#?");
                System.Console.WriteLine("a.int");
                System.Console.WriteLine("b.continue");
                System.Console.WriteLine("c.break");
                System.Console.WriteLine("d.exit");
                System.Console.WriteLine("Enter answer");
                user=Console.ReadLine();
                if(user==correct)
                {
                    System.Console.WriteLine("Correct");
                    break;
                }
                else
                {
                    System.Console.WriteLine("Incorrect");
                    System.Console.WriteLine("Try Again? press y to continue:");
                    contiue=Console.ReadLine().ToLower();
                    
                }
            }while(contiue=="y");

        }
    }
}