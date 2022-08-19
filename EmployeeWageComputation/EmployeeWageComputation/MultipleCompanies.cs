using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class MultipleCompanies
    {
        public string Company_name;
        public int Wage_Per_Hr;
        public int Full_Hr_Per_Day;
        public int Part_Hr_Per_Day;
        public int Max_Working_Days;
        public int Max_Working_Hrs;

        public MultipleCompanies(string Company_Name, int Wage_Per_Hr, int Full_Hr_Per_Day, int Part_Hr_Per_Day, int Max_Working_Days, int Max_Working_Hrs)
        {
            this.Company_name = Company_Name;
            this.Wage_Per_Hr = Wage_Per_Hr;
            this.Full_Hr_Per_Day = Full_Hr_Per_Day;
            this.Part_Hr_Per_Day = Part_Hr_Per_Day;
            this.Max_Working_Hrs = Max_Working_Hrs;
            this.Max_Working_Days = Max_Working_Days;
        }
    }

    class Wage_Computation
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public Dictionary<string, MultipleCompanies> Companies_Dict;

        public Wage_Computation()
        {
            Companies_Dict = new Dictionary<string, MultipleCompanies>();

        }

        public void AddCompany(string Company_Name, int Wage_Per_Hr, int Full_Hr_Per_Day, int Part_Hr_Per_Day, int Max_Working_Days, int Max_Working_Hrs)

        {
            MultipleCompanies comp_obj = new MultipleCompanies(Company_Name.ToLower(), Wage_Per_Hr, Full_Hr_Per_Day, Part_Hr_Per_Day, Max_Working_Days, Max_Working_Hrs);
            Companies_Dict.Add(Company_Name.ToLower(), comp_obj);

        }
        public int Present_Check()
        {
            return new Random().Next(0, 3);
        }
        public void Calculations(string Company_Name)
        {
            int Hr_Per_Day = 0;
            int Wage_Per_Day = 0;
            int Total_Working_Hrs = 0;
            int Present_Days = 0;
            int Monthly_Wage = 0;

            if (!Companies_Dict.ContainsKey(Company_Name.ToLower()))
                throw new ArgumentNullException("Company doesnot exist!");
            Companies_Dict.TryGetValue(Company_Name.ToLower(), out MultipleCompanies comp_obj);
            while (Total_Working_Hrs < comp_obj.Max_Working_Hrs && Present_Days < comp_obj.Max_Working_Days)
            {
                switch (Present_Check())
                {
                    case Full_Time:
                        Hr_Per_Day = comp_obj.Full_Hr_Per_Day;
                        Present_Days++;
                        break;
                    case Part_Time:
                        Hr_Per_Day = comp_obj.Part_Hr_Per_Day;
                        Present_Days++;
                        break;
                    default:
                        Hr_Per_Day = 0;
                        break;

                }
                Total_Working_Hrs += Hr_Per_Day;
                Wage_Per_Day = (comp_obj.Wage_Per_Hr * Hr_Per_Day);                
                Monthly_Wage += Wage_Per_Day;
            }
            Console.WriteLine("For " + Company_Name);
            Console.WriteLine("Total hours worked=" + Total_Working_Hrs);
            Console.WriteLine("Total Days Present=" + Present_Days);
            Console.WriteLine("Monthly Wage=" + Monthly_Wage + "\n");





        }
    }
}
