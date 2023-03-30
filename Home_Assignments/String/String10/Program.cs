using System;
namespace String10
{
    class Program
    {


        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter string ");
            string str=Console.ReadLine();
           string upper=str.ToUpper();
           char[] array=upper.ToCharArray();
           Array.Reverse(array);
           string rev=new string(array);
           System.Console.WriteLine("string: "+str);
           System.Console.WriteLine("upper case: "+rev);

        }
    }
}