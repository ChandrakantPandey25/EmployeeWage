using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace EmployeeWageComputation
{
    class TotalWageMultiCompanyArrayList
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public string Company_name;
        public int Wage_Per_Hr;
        public int Full_Hr_Per_Day = 8;
        public int Part_Hr_Per_Day = 4;
        public int Max_Working_Days;
        public int Max_Working_Hrs;
        int wagesPerMonth = 0;
        ArrayList empMWage;
        //TotalWageMultiCompanyArray[] companies;
        //int compCount;

        public TotalWageMultiCompanyArrayList(string Company_Name, int Wage_Per_Hr, int Full_Hr_Per_Day, int Part_Hr_Per_Day, int Max_Working_Days, int Max_Working_Hrs)
        {
            this.Company_name = Company_Name;
            this.Wage_Per_Hr = Wage_Per_Hr;
            this.Full_Hr_Per_Day = Full_Hr_Per_Day;
            this.Part_Hr_Per_Day = Part_Hr_Per_Day;
            this.Max_Working_Hrs = Max_Working_Hrs;
            this.Max_Working_Days = Max_Working_Days;
            //companies = new TotalWageMultiCompanyArray[6];
            //compCount = 0;
            empMWage = new ArrayList();
        }
        public void MonthlyWages(int Monthly_Wage)
        {
            this.wagesPerMonth = Monthly_Wage;
            Console.WriteLine($"Wages for the company {Company_name} for the month : {wagesPerMonth}");
        }


        public void AddCompany(string Company_Name, int Wage_Per_Hr, int Full_Hr_Per_Day, int Part_Hr_Per_Day, int Max_Working_Days, int Max_Working_Hrs)

        {
            TotalWageMultiCompanyArrayList company = new TotalWageMultiCompanyArrayList(Company_Name.ToLower(), Wage_Per_Hr, Full_Hr_Per_Day, Part_Hr_Per_Day, Max_Working_Days, Max_Working_Hrs);
            company.MonthlyWages(this.Calculations(company));
            //companies[compCount] = company;
            //compCount++;
            empMWage.Add(company);



        }
        public int Present_Check()
        {
            return new Random().Next(0, 3);
        }
        public int Calculations(TotalWageMultiCompanyArrayList company)
        {
            int Hr_Per_Day = 0;
            int Wage_Per_Day = 0;
            int Total_Working_Hrs = 0;
            int Present_Days = 0;
            int Monthly_Wage = 0;


            while (Total_Working_Hrs < company.Max_Working_Hrs && Present_Days < company.Max_Working_Days)
            {
                switch (Present_Check())
                {
                    case Full_Time:
                        Hr_Per_Day = company.Full_Hr_Per_Day;
                        Present_Days++;
                        break;
                    case Part_Time:
                        Hr_Per_Day = company.Part_Hr_Per_Day;
                        Present_Days++;
                        break;
                    default:
                        Hr_Per_Day = 0;
                        break;

                }
                Total_Working_Hrs += Hr_Per_Day;
                Wage_Per_Day = (company.Wage_Per_Hr * Hr_Per_Day);
                Monthly_Wage += Wage_Per_Day;
            }
            return Monthly_Wage;

            Console.WriteLine("Wages in a Month:" + Monthly_Wage + "\n");
        }

        //public static implicit operator TotalWageMultiCompanyArray(TotalWageMultiCompanyIFace v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
