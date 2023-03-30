using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter grade: ");
            float grade = float.Parse(Console.ReadLine());
            if(grade>=5.50)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Not Excellent");
            }
        
        }
    }
}
