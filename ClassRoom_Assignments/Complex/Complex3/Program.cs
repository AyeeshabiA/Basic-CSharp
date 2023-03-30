using System;
namespace Complex3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter name1: ");
            string name1=Console.ReadLine();
            Console.WriteLine("Enter name2: ");
            string name2=Console.ReadLine();
            char[]arrayName1=name1.ToCharArray();
            char[]arrayName2=name2.ToCharArray();
            Array.Sort(arrayName1);
            Array.Sort(arrayName2);
            string strName1=arrayName1.ToString();
            string strName2=arrayName2.ToString();
            if(strName1.Equals(strName2))
            {
                Console.WriteLine("It is a anogram");
            }
            else{
                 Console.WriteLine("It is not a anogram");
            }
        }

    }
}
