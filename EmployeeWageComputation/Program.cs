using System;

namespace EmployeeWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWageComputation emp = new EmpWageComputation();
            emp.MultipleCompanies("Google", 20, 5, 10);
            emp.MultipleCompanies("Apple", 15, 4, 15);


            //emp.EmployeeWageUsingSwitch();
            //emp.CheckEmpPresentOrNot();
            //emp.CheckEmpFullOrPartTime();
            //emp.CalcEmpDailyWage();


        }
    }
}
