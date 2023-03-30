using System;
namespace String7
{
    class Program
    {


        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter string");
            string word=Console.ReadLine();
            System.Console.WriteLine("Enter string to search");
            string search=Console.ReadLine();
            System.Console.WriteLine("Enter string to insert");
            string insert=Console.ReadLine();
            int index=word.IndexOf(search);
            insert=" "+insert.Trim()+" ";
            word=word.Insert(index,insert);
            System.Console.WriteLine($"string: "+word);
            
        }
    }
}