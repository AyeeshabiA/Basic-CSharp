using System;
namespace String6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter string");;
            string str=Console.ReadLine().ToLower();
            int vowel=0;
            int consonant=0;
            for(int i=0;i<str.Length;i++)
            {
                char c=str[i];
                if(c=='a'&&c=='e'&&c=='i'&&c=='u'&&c=='o')
                {
                    vowel++;
                }
                else if(c=='b'&&c=='z'&&c=='i'&&c=='e'&&c=='o'&&c=='u')
                {
                    consonant++;
                }
            }
            System.Console.WriteLine("vowel: "+vowel);
            System.Console.WriteLine("Consonant: "+consonant);
            
        }
    }
}