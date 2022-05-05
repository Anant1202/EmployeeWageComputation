using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageComputation
    {
        int WAGE_PER_HOUR = 20;
        int FULL_DAY_HOUR = 8;
        bool IsPresent;
        public void CheckEmpPresentOrNot()
        {
            Random generatenum=new Random();
            int num=generatenum.Next(0,2);
            if (num == 1) 
            {
                IsPresent = true;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                IsPresent=false;
                Console.WriteLine("Employee is absent");
            }
        }
        public void CalcEmpDailyWage()
        {
            int empDailyWage=0;
            if (IsPresent)
            {
                empDailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
    
            }
            else
            {
                empDailyWage = 0;
            }
            Console.WriteLine("Employee Daily Wage is {0}", empDailyWage);
        }
    }

}
