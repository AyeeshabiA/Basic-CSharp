using System;
namespace Complex4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter name: ");
            string name=Console.ReadLine();
            char[]arrayName=name.ToCharArray();
            string string1="";
            for(i=0;i<=arrayName.Length;i++)
            {
               if(!string1.Contains(arrayName[i]))
               {
                   string1+=arrayName[i];
               }
            }
            Console.Write(string1);
            
            
        }

    }
}
