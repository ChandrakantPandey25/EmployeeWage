using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class EmpPartTimeWage
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HR = 20;

        public  int EmplPartimeWage()
        {


            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                int empHr = 8;
                empWage = empHr * EMP_RATE_PER_HR;

            }
            else if (empCheck == IS_PART_TIME)
            {
                int empHr = 4;
                empWage = empHr * EMP_RATE_PER_HR;

            }
            else
            {
                int empHr = 0;
                empWage = empHr * EMP_RATE_PER_HR;
            }

            return empWage;
        }
    }
}
