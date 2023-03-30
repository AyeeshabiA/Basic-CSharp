using System;
namespace String8
{
    class Program
    {


        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter name 1");
            string name1=Console.ReadLine();
            System.Console.WriteLine("Enter name 2");
            string name2=Console.ReadLine();
            string lastName1=name1.Substring(name1.LastIndexOf(" ")+1);
            string lastName2=name2.Substring(name1.LastIndexOf(" ")+1);
            if(string.Compare(lastName1,lastName2)<0)
            {
                System.Console.WriteLine(name1);
                System.Console.WriteLine(name2);
            }
            else
            {
                System.Console.WriteLine(name1);
                System.Console.WriteLine(name2);
            }
        }
    }
}