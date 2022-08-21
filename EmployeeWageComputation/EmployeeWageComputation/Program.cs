using System;
using static EmployeeWageComputation.TotalWageMultiCompanyIFace;
using static EmployeeWageComputation.Wage_Computation;

namespace EmployeeWageComputation
{
    class Program
    {
        public static string Company_Name { get; private set; }
        public static int Wage_Per_Hr { get; private set; }
        public static int Full_Hr_Per_Day { get; private set; }
        public static int Part_Hr_Per_Day { get; private set; }
        public static int Max_Working_Days { get; private set; }
        public static int Max_Working_Hrs { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation");
            Console.WriteLine("Enter 1: To check Employee Attendance");
            Console.WriteLine("Enter 2: To check Employee Daily Wage");
            Console.WriteLine("Enter 3: To check Employee Parttime Daily Wage");
            Console.WriteLine("Enter 4: To check Employee Parttime Daily Wage using Switch Case");
            Console.WriteLine("Enter 5: To check Employee Monthly Wage");
            Console.WriteLine("Enter 6: To check Employee Monthly Wage using Switch Case ");
            Console.WriteLine("Enter 8: To check Employee Monthly Wage for multiple companies using Switch Case ");
            Console.WriteLine("Enter 9: To check Employee Monthly Wage for multiple companies using Array ");
            Console.WriteLine("Enter 10: To check Employee Monthly Wage for multiple companies using Interface ");
            Console.WriteLine("Enter 11: To check Employee Monthly Wage for multiple companies using ArrayList ");
            
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
                case 8:
                    Wage_Computation Employee = new Wage_Computation();

                    Employee.AddCompany("TCS", 15, 8, 4, 100, 20);
                    Employee.Present_Check();
                    Employee.Calculations("TCS");
                    break;
                case 9:
                    TotalWageMultiCompanyArray empWageBuilder = new TotalWageMultiCompanyArray(Company_Name, Wage_Per_Hr, Full_Hr_Per_Day, Part_Hr_Per_Day, Max_Working_Days, Max_Working_Hrs);

                    empWageBuilder.AddCompany("TCS", 20, 8, 4,80,20);
                    empWageBuilder.AddCompany("HUNDAI", 20, 8, 4, 90, 20);                   
                    break;
                case 10:
                    TotalWageMultiCompanyIFace empWage_Builder = new TotalWageMultiCompanyIFace(/*Company_Name, Wage_Per_Hr, Full_Hr_Per_Day, Part_Hr_Per_Day, Max_Working_Days, Max_Working_Hrs*/);

                    empWage_Builder.AddCompany("TCS", 20, 80, 20,10,200);
                    empWage_Builder.AddCompany("HUNDAI", 20, 90, 20,25,50);
                    
                    break;
                case 11:
                    TotalWageMultiCompanyArrayList empWage_builder = new TotalWageMultiCompanyArrayList(Company_Name, Wage_Per_Hr, Full_Hr_Per_Day, Part_Hr_Per_Day, Max_Working_Days, Max_Working_Hrs);

                    empWage_builder.AddCompany("TCS", 20, 80, 20, 10, 200);
                    empWage_builder.AddCompany("HUNDAI", 20, 90, 20, 25, 50);

                    break;


                default:
                    Console.WriteLine("Enter Valid Number");
                    break;
            }
        }
    }
}
