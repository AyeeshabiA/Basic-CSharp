using System;
namespace Question14
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter string");
            string input=Console.ReadLine().ToLower();
            char[]array=input.ToCharArray();
            int c=0;
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]=='a'||array[i]=='e'||array[i]=='i'||array[i]=='o'||array[i]=='u')
                {
                    c++;
                }
            }
            System.Console.WriteLine("count: "+c);
        }
    }
}