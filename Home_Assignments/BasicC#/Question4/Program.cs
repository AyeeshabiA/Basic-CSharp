using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* .	CM = meter * 100
a.	Mm – CM * 10
b.	Inch – 39.3 * meter
c.	Foot – 12 * meter
d.	Mile –0.0006213715277778*meter*/

            //Parse method
            Console.WriteLine("Enter Length: ");
            int length=int.Parse(Console.ReadLine());
            int cm=length*100;
            Console.WriteLine("CM= "+cm);
            int mm=cm*10;
            Console.WriteLine("Mm= "+mm);
            double inch=39.3*length;
            Console.WriteLine("Inch= "+inch);
            int foot=length*12;
            Console.WriteLine("Foot= "+foot);
            double mile=0.0006213715277778*length;
            Console.WriteLine("Mile= "+mile);
            

        }
    }
}


