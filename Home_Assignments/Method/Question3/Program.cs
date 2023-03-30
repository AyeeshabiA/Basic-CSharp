using System;
namespace  Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int [] array={3,7,5,2,9};
            int sum=0,i;
            for(i=0;i<array.Length;i++)
            {
                sum+=array[i];
            }
            Console.WriteLine("answer= "+sum);
        }
    }
}
    
