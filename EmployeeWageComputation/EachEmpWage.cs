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
        public Company[] companies;
        public int numberOfCompany = 0;

        public EachEmpWage()
        {
            companies = new Company[5];
        }

        public void AddCompanyObjectsIntoArray(string compny, int workingDays,int ratePerHr, int workingHrs)
        {
            Company obj = new Company(compny, workingDays, workingHrs, ratePerHr);
            companies[numberOfCompany] = obj;
            numberOfCompany++;
        }
        public void IterateOverArray()
        {
            foreach(Company comp in companies)
            {
                if (comp != null)
                {
                    int totalwage = CalculateEmpWage(comp);
                    comp.SetTotalWage(totalwage);
                }
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


            Random random = new Random();
            while (day <= company.maxWorkingHrs && totalWorkingHrs <= company.maxWorkingHrs)
            {
                int employeeInput = random.Next(0, 3);// 0 or 1 or 2
                //Console.WriteLine("Random value:{0}", employeeInput);
                switch (employeeInput)
                {
                    case FULL_TIME:
                        //code block
                        //Console.WriteLine("FullTime Employee Is Present");
                        empHr = 8;
                        break;
                    case PART_TIME:
                        //code block
                        //Console.WriteLine("PartTime Employee Is Present");
                        empHr = 4;
                        break;
                    default:
                        //Console.WriteLine("Employee Is Not Present");
                        empHr = 0;
                        break;
                }
                empWage = empHr * company.empRatePerHr;
                totalWage = totalWage + empWage;
                //Console.WriteLine("Day{0} Employee WAGE Is:{1}", day, empWage);
                day++;
                totalWorkingHrs = totalWorkingHrs + empHr;
                if (totalWorkingHrs > company.maxWorkingHrs)
                    totalWorkingHrs = totalWorkingHrs - empHr;

            }
            Console.WriteLine("Total Wage for {0}: {1} days and Hrs:{2} is:{3}", company.CompanyName, (day - 1), (totalWorkingHrs), totalWage);
            return totalWage;
        }
    }
}
