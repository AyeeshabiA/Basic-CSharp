using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());
            double areaGround = N * N;
            double areaBench = M * O;
            Double areaTile = W * L;
            double tilesNeed = (areaGround - areaBench) / areaTile;
            double time = tilesNeed * 0.2;
            System.Console.WriteLine(Math.Ceiling(tilesNeed));
            System.Console.WriteLine(time);
        }
    }
}