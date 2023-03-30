using System;
namespace String4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter string1");;
            string str1=Console.ReadLine();
            System.Console.WriteLine("Enter string2");;
            string str2=Console.ReadLine();
           if(str1==str2)
           {
            System.Console.WriteLine("Equal");
           }
           else
           {
            System.Console.WriteLine("Not equal");
           }
        }
    }
}