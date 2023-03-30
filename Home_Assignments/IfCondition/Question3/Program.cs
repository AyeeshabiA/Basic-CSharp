using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Athlete1 time");
            int time1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Athlete2 time");
            int time2=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Athlete3 time");
            int time3=int.Parse(Console.ReadLine());
            int sec=time1+time2+time3;
            int min=sec/60;
            int sec1=sec%10;
            string min1=(min<10)?"0"+min:min.ToString();
             string sec2=(sec1<10)?"0"+sec1:sec1.ToString();
             System.Console.WriteLine("Time: "+min1+":"+sec2);

        }
    }
}