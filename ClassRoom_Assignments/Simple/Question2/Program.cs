using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int basicSalary=10000;
            int da=10000*10/100;
            int hra=10000*10/100;
            int perMonth=basicSalary+da+hra;
            int annualIncome=perMonth*12;
            int taxesPerAnnum=annualIncome*5/100;
            int finalAnnualIncome=annualIncome-taxesPerAnnum;
            Console.WriteLine("Basic salary= "+basicSalary);
            Console.WriteLine("DA= "+da);
            Console.WriteLine("HRA= "+hra);
            Console.WriteLine("Per Month Salary= "+perMonth);
            Console.WriteLine("Taxes per annum= "+taxesPerAnnum);
            Console.WriteLine("Annual Income= "+finalAnnualIncome);

            
        }
    }
}