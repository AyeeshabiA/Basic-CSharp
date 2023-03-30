using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
          
          Console.WriteLine("Enter the Amount: ");
          int amount=int.Parse(Console.ReadLine());
          double usd=(double)amount*0.01212;
          double eur=(double)amount*0.0127;
          double cny=(double)amount*0.08789;
          Console.WriteLine("USD= "+usd);
          Console.WriteLine("EUR= "+eur);
          Console.WriteLine("CNY= "+cny);
        }
    }
}
