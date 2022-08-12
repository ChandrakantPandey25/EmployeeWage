using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation");
            Console.WriteLine("Enter 1: To check Employee Attendance");
            Console.WriteLine("Enter 2: To check Employee Daily Wage");
            Console.WriteLine("Enter 3: To check Employee Parttime Daily Wage");
            Console.WriteLine("Enter 4: To check Employee Parttime Daily Wage using Switch Case");
            Console.WriteLine("Enter 5: To check Employee Monthly Wage");
            Console.WriteLine("Enter 6: To check Employee Monthly Wage using Switch Case ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    EmpAttendance.CheckEmployeePresentorAbsent();
                    break;
                case 2:
                    EmployeeWage wage = new EmployeeWage();
                    wage.EmpDailyWage();
                    break;
                case 3:
                    EmpPartTimeWage WageParttime = new EmpPartTimeWage();
                    WageParttime.EmplPartimeWage();
                    break;
                case 4:
                    EmpParttimeWageSwitchCase WageSwitch = new EmpParttimeWageSwitchCase();
                    WageSwitch.WageSwitchCase();
                    break;
                case 5:
                    EmpWageMonthly wageMonthly = new EmpWageMonthly();
                    wageMonthly.Wages_Month();
                    break;
                case 6:
                    EmpMonthlyWageSwitchCase Monthly = new EmpMonthlyWageSwitchCase();
                    Monthly.MonthlyWageSwitchCase();
                    break;



                default:
                    Console.WriteLine("Enter Valid Number");
                    break;
            }
        }
    }
}
