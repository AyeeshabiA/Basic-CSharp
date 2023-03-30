using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter gender (m/f) ");
            string gender=Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age=int.Parse(Console.ReadLine());
            if(gender=="m")
            {
                if(age>=16)
                {
                    Console.WriteLine("Mr.");
                }
                else{
                    Console.WriteLine("Master");
                }
            }
            else if(gender=="f")
            {
                if(age>=16)
                {
                    Console.WriteLine("Ms.");
                }
                else{
                    Console.WriteLine("Miss");
                }
            }
            else{
                Console.WriteLine("Invalid");
            }
        }
    }
}
