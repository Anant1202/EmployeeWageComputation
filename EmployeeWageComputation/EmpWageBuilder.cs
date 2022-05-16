using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilder
    {
        public const int Is_PartTime = 1;
        public const int Is_FullTime = 2;

        public string company;
        public int Emp_Wage_Per_Hour;
        public int Working_days;
        public int Total_Working_Hours;
        public int totalwage;

        public EmpWageBuilder(string company, int Emp_Wage_Per_Hour, int Working_days, int Total_Working_Hours)
        {
            this.company = company;
            this.Emp_Wage_Per_Hour = Emp_Wage_Per_Hour;
            this.Working_days = Working_days;
            this.Total_Working_Hours = Total_Working_Hours;
        }
        public void CalculateEmpWage()
        {
            int emphrs = 0, day = 1, totalhours = 0;

            while (totalhours <= this.Total_Working_Hours && day <= this.Working_days)
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
            Console.WriteLine("Total Employee Wage for Company " + company + " is " + totalwage);
        }
    }   
}
