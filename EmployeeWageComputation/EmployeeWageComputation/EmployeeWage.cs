using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        public int EmpDailyWage()
        {
            int IS_FULL_TIME = 1, empWage = 0;
            int RATE_PER_HR = 20;

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                int empHr = 8;
                empWage = empHr * RATE_PER_HR;

            }
            else
            {
                int empHr = 0;
                empWage = empHr * RATE_PER_HR;

            }
            Console.WriteLine("Employee Daily Wage is :" + empWage);
            return empWage;
        }
    }
}
