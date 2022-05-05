using System;

namespace EmployeeWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWageComputation emp = new EmpWageComputation();
            emp.EmployeeWageUsingSwitch();
            //emp.CheckEmpPresentOrNot();
            //emp.CheckEmpFullOrPartTime();
            //emp.CalcEmpDailyWage();
            

        }
    }
}
