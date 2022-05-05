using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageComputation
    {
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
    }
}
