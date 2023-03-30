using System;
namespace Question13
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter string");
            string input=Console.ReadLine();
            char [] array=input.ToCharArray();
            string rev="";
            for(int i=array.Length-1;i>=0;i--)
            {
                rev+=array[i];
            }
            System.Console.WriteLine(rev);
        }
    }
}