using System;
namespace Medium5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int s=0;
            Console.WriteLine("Enter starting number: ");
            int startNumber=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Difference between number: ");
            int differenceNumber=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number element: ");
            int elementNumber=int.Parse(Console.ReadLine());
            
            while(elementNumber!=0)
            {
                
                s=s+startNumber;
                Console.WriteLine(startNumber);
                elementNumber--;
                startNumber=startNumber+differenceNumber;
            }
             Console.WriteLine("Sum is "+s);
        }
    }
}
