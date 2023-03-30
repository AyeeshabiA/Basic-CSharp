using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {  
            int sum=0;
            Console.WriteLine("Enter Physics marks: ");
            sum+=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chemistry marks: ");
            sum+=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Maths marks: ");
            sum+=int.Parse(Console.ReadLine());
            int percentage=sum/300*100;
            Console.WriteLine("sum: "+sum);
            Console.WriteLine("percentage: "+percentage);
            
        }
    }
}
