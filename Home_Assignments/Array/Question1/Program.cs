using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[]element= new int[10]{1,2,3,4,5,6,7,8,9,0};
            foreach (int elements in element)
            {
                Console.Write(elements+" ");
            }

        }
    }
}