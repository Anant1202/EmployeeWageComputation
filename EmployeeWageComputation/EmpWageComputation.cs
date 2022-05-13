using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageComputation
    {
        //int WAGE_PER_HOUR = 20;
        //int FULL_DAY_HOUR = 8;
        //int PART_TIME_HOUR = 4;
        //bool IsPresent; 
        //bool IsFullTime;
        //Random generatenum = new Random();
        //public void CheckEmpPresentOrNot()
        //{
        //    int num=generatenum.Next(0,2);
        //    if (num == 1) 
        //    {
        //        IsPresent = true;
        //        Console.WriteLine("Employee is Present");
        //    }
        //    else
        //    {
        //        IsPresent=false;
        //        Console.WriteLine("Employee is absent");
        //    }
        //}
        //public void CheckEmpFullOrPartTime()
        //{
        //    int num = generatenum.Next(0, 2);
        //    if (num == 1)
        //    {
        //        IsFullTime = true;
        //        Console.WriteLine("Full Time Employee ");
        //    }
        //    else
        //    {
        //        IsFullTime = false;
        //        Console.WriteLine("Part Time Employee ");
        //    }
        //}
        //public void CalcEmpDailyWage()
        //{
        //    int empDailyWage=0;
        //    if (IsPresent && IsFullTime)
        //    {
        //        empDailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;

        //    }
        //    else if (IsPresent && !IsFullTime)
        //    {
        //        empDailyWage = WAGE_PER_HOUR * PART_TIME_HOUR;

        //    }
        //    Console.WriteLine("Employee Daily Wage is {0}", empDailyWage);
        //}


        //public const int Is_PartTime = 1;
        //public const int Is_FullTime = 2;
        //public const int Emp_Wage_Per_Hour = 20;
        //public const int Working_days = 20;
        //public const int Total_Working_Hours = 100;

        //public void EmployeeWageUsingSwitch()
        //{

        //    int emphrs = 0, totalwage = 0, day = 1, totalhours=0;

        //    while(totalhours<=Total_Working_Hours && day<=Working_days)
        //    {   

        //        Random random = new Random();
        //        int empcheck = random.Next(0, 3);
        //        switch (empcheck)
        //        {
        //            case Is_PartTime:
        //                emphrs = 4;
        //                break;
        //            case Is_FullTime:
        //                emphrs = 8;
        //                break;

        //            default:
        //                emphrs = 0;
        //                break;
        //        }
        //        totalhours += emphrs;
        //        Console.WriteLine("Day:"+ day + "Emp Hrs" +emphrs);
        //        day++;   
        //    }
        //    totalwage=totalhours*Emp_Wage_Per_Hour;
        //    Console.WriteLine("Total Wage is " + totalwage);
        //}
        public const int Is_PartTime = 1;
        public const int Is_FullTime = 2;
        public void MultipleCompanies( string company,int Emp_Wage_Per_Hour,int Working_days,int Total_Working_Hours)
        {

            int emphrs = 0, totalwage = 0, day = 1, totalhours = 0;

            while (totalhours <= Total_Working_Hours && day <= Working_days)
            {

                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case Is_PartTime:
                        emphrs = 4;
                        break;
                    case Is_FullTime:
                        emphrs = 8;
                        break;

                    default:
                        emphrs = 0;
                        break;
                }
                totalhours += emphrs;
                Console.WriteLine("Day: " + day + "Emp Hrs:" + emphrs);
                day++;
            }
            totalwage = totalhours * Emp_Wage_Per_Hour;
            Console.WriteLine("Total Wage is " + totalwage);
        }
    }
}