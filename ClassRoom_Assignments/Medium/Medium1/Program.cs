using System;
namespace Medium1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter basic salary: ");
            int basicSalary=int.Parse(Console.ReadLine());
           
            if(basicSalary<=10000)
            {
                int hra=10000*20/100;
                int da=10000*80/100;
                int finalBasicSalary=basicSalary+hra+da;
                int grossAnnualSalary=finalBasicSalary*12;
                int taxes=grossAnnualSalary*6/100;
                int insurance=grossAnnualSalary*1/100;
                int takeHomeSalary=grossAnnualSalary-taxes-insurance;
                Console.WriteLine("Gross Annual Salary= "+grossAnnualSalary);
                Console.WriteLine("Take Home Salary= "+takeHomeSalary);

            }
            else if(basicSalary<=20000&&basicSalary>=10000)
            {
                int hra=10000*25/100;
                int da=10000*90/100;
                int finalBasicSalary=basicSalary+hra+da;
                int grossAnnualSalary=finalBasicSalary*12;
                int taxes=grossAnnualSalary*6/100;
                int insurance=grossAnnualSalary*1/100;
                int takeHomeSalary=grossAnnualSalary-taxes-insurance;
                Console.WriteLine("Gross Annual Salary= "+grossAnnualSalary);
                Console.WriteLine("Take Home Salary= "+takeHomeSalary);

            }
            else if(basicSalary>20000)
            {
                int hra=10000*30/100;
                int da=10000*95/100;
                int finalBasicSalary=basicSalary+hra+da;
                int grossAnnualSalary=finalBasicSalary*12;
                int taxes=grossAnnualSalary*6/100;
                int insurance=grossAnnualSalary*1/100;
                int takeHomeSalary=grossAnnualSalary-taxes-insurance;
                Console.WriteLine("Gross Annual Salary= "+grossAnnualSalary);
                Console.WriteLine("Take Home Salary= "+takeHomeSalary);

            }
        }
    }
}
