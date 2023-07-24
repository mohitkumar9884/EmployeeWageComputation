using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EachEmpWage
    {
        //int[] arr = new Array[5];
        //public Company[] companies;
        public List<Company> listOfCompanies;    
        public int numberOfCompany = 0;

        public EachEmpWage()
        {
            //companies = new Company[5];
            listOfCompanies = new List<Company>();
        }

        public void AddCompanyObjectsIntoArray(string compny,int workingDays, int workingHrs,int ratePerHr )
        {
            Company obj = new Company(compny, workingDays, workingHrs, ratePerHr);
           // companies[numberOfCompany] = obj;
            listOfCompanies.Add(obj);
            //numberOfCompany++;
        }
        public void IterateOverArray()
        {
            foreach(Company comp in listOfCompanies)
            {               
                    int totalwage = CalculateEmpWage(comp);
                    comp.SetTotalWage(totalwage); 
                    Console.WriteLine(comp.ToString());
                    //Console.WriteLine(comp.CompanyName+"" +comp.empRatePerHr);
            }
        }
         
        public int CalculateEmpWage(Company company)
        {
            const int FULL_TIME = 0;
            const int PART_TIME = 2;

            int empHr = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalWorkingHrs = 0;
            List<int> listOfDailyWage = new List<int>();


        Random random = new Random();
            while (day <= company.numberOfWorkingDays && totalWorkingHrs <= company.maxWorkingHrs)
            {
                int employeeInput = random.Next(0, 3);// 0 or 1 or 2
                //Console.WriteLine("Random value:{0}", employeeInput);
                switch (employeeInput)
                {
                    case FULL_TIME:
                        //code block

                        empHr = 8;
                        break;
                    case PART_TIME:
                        //code block

                        empHr = 4;
                        break;
                    default:
 
                        empHr = 0;
                        break;
                }
                empWage = empHr * company.empRatePerHr;
                listOfDailyWage.Add(empWage);
                totalWage = totalWage + empWage;
 
                day++;
                totalWorkingHrs = totalWorkingHrs + empHr;
                if (totalWorkingHrs > company.maxWorkingHrs)
                    totalWorkingHrs = totalWorkingHrs - empHr;
            }
            Console.WriteLine("\nDaily Wage for {0} is:",company.CompanyName);
            foreach (int wage in listOfDailyWage)
            {
                Console.Write(wage+" ");
            }
            //Console.WriteLine("Total Wage for {0}: {1} days and Hrs:{2} is:{3}", company.CompanyName, (day - 1), (totalWorkingHrs), totalWage);
            return totalWage;
        }
    }
}
