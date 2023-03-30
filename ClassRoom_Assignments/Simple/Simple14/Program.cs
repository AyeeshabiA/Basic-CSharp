using System;
namespace Simple14
{
    class Program
    {
        public static async void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");
            string word=Console.ReadLine();
            char[] character=word.ToCharArray();
            int count=0;
            for(int i=character.Length-1;i>=0;i--)
            {
                if(character[i]=='a'||character[i]=='e'||character[i]=='i'||character[i]=='o'||character[i]=='u')
                {
                    count++;
                }
            }
            Console.WriteLine("count of vowels: "+count);
        }
    }
}
