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
        int PART_TIME_HOUR = 4;
        bool IsPresent; 
        bool IsFullTime;
        Random generatenum = new Random();
        public void CheckEmpPresentOrNot()
        {
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
        public void CheckEmpFullOrPartTime()
        {
            int num = generatenum.Next(0, 2);
            if (num == 1)
            {
                IsFullTime = true;
                Console.WriteLine("Full Time Employee ");
            }
            else
            {
                IsFullTime = false;
                Console.WriteLine("Part Time Employee ");
            }
        }
        public void CalcEmpDailyWage()
        {
            int empDailyWage=0;
            if (IsPresent && IsFullTime)
            {
                empDailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
    
            }
            else if (IsPresent && !IsFullTime)
            {
                empDailyWage = WAGE_PER_HOUR * PART_TIME_HOUR;
               
            }
            Console.WriteLine("Employee Daily Wage is {0}", empDailyWage);
        }
    }

}
