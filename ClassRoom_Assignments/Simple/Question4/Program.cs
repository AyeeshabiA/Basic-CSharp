﻿using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number=int.Parse(Console.ReadLine());
            if(number<100)
            {
                Console.WriteLine("Less than 100");
            }
            if(number>100&&number<200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            if(number>200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
