using System;
namespace Simple13
{
    class Program
    {
        public static async void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string word=Console.ReadLine();
            char[] character=word.ToCharArray();
            string reverse="";
            for(int i=character.Length-1;i>=0;i--)
            {
                reverse=reverse+character[i];
            }
            Console.WriteLine(reverse);
        }
    }
}
