using System;
namespace String9
{
    class Program
    {


        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter string 1");
            string str1=Console.ReadLine();
            System.Console.WriteLine("Enter string 2");
            string str2=Console.ReadLine();
           int result=string.CompareOrdinal(str1.ToLower(),str2.ToLower());
           if(result<0)
           {
            System.Console.WriteLine(" string 1 is less than string 2");
           }
           else if(result>0)
           {
             System.Console.WriteLine(" string 1 is greater than string 2");
           }
           else 
           {
             System.Console.WriteLine(" string 1 is  equal to string 2");
           }
        }
    }
}