using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 1.You deposit Rs 1000.00 in the bank account at 5% annual compound interest. 
The interest is paid once at the end of the year
What if you are interested in earning more than 100000? How long will it take to reach this mark?*/
namespace AllamRohithReddy_Assessment
{
    internal class Interest
    {
        public double deposit = 1000;
        public double Amount = 1000;
        public double CalInterest(double amount)
        {
            double ins = amount * 0.05;
            return ins;
        }
        public static void Main()
        {
            Interest ins =new Interest();
            Console.WriteLine($"year            interest of the year            End of the year amount");
            int i = 1;
            while((ins.Amount + ins.CalInterest(ins.Amount) )< 100001)
            {
                double pastAmount=ins.Amount;
                ins.Amount = ins.Amount + ins.CalInterest(ins.Amount);
                Console.WriteLine($"{i}          {pastAmount}*0.05={pastAmount*0.05}            {ins.Amount}");
                i++;
            }

        }
    }

}
