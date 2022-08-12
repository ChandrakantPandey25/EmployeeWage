using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation");
            Console.WriteLine("Enter 1: To check Employee Attendance");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    EmpAttendance.CheckEmployeePresentorAbsent();
                    break;
                default:
                    Console.WriteLine("Enter Valid Number");
                    break;
            }
        }
    }
}
