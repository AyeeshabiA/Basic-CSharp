using System;
namespace String2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int c=0;
            Console.WriteLine("Enter a string: ");
            string sentence=Console.ReadLine();
            foreach(char word in sentence)
            {
                c++;
            }
            Console.WriteLine("The length of the string is: "+c);
        }
    }
}