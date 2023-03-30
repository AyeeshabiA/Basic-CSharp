using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Password: ");
            string password=Console.ReadLine();
            if(password=="s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            
            }
            else{
                 Console.WriteLine("Wrong Password");
            }
        }
    }
}
