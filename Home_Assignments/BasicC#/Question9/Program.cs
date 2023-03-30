using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter value1: ");
            int value1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value2: ");
            int value2=int.Parse(Console.ReadLine());
            bool result=bool.Parse(value1>value2?"true":"false");
            Console.WriteLine(result);
            bool result1=bool.Parse(value1<value2?"true":"false");
            Console.WriteLine(result1);
            bool result3=bool.Parse(value1>=value2?"true":"false");
            Console.WriteLine(result3);
            bool result4=bool.Parse(value1==value2?"true":"false");
            Console.WriteLine(result4);
            bool result5=bool.Parse(value1!=value2?"true":"false");
            Console.WriteLine(result5);
            bool result6=bool.Parse(value1<=value2?"true":"false");
            Console.WriteLine(result6);
            bool result7=bool.Parse(value1>=10&&value2>=10?"true":"false");
            Console.WriteLine(result7);
            bool result8=bool.Parse(value1>=10||value2>=30?"true":"false");
            Console.WriteLine(result8);
            bool result9=!(value1>20);
            Console.WriteLine(result8);
            
            
        }
    }
}

