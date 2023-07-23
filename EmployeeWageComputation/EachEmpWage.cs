using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EachEmpWage
    {
        public string companyName;
        public int numberOfWorkingDays, maxWorkingHrs, empRatePerHr;

        public EachEmpWage(string company, int workingDays, int workingHrs, int ratePerHr)
        {
            companyName = company;
            numberOfWorkingDays = workingDays;
            maxWorkingHrs = workingHrs;
            empRatePerHr = ratePerHr;
        }

        public void CalculateEmpWage()
        {
            const int FULL_TIME = 0;
            const int PART_TIME = 2;

            int empHr = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int totalWorkingHrs = 0;


            Random random = new Random();
            while (day <= maxWorkingHrs && totalWorkingHrs <= maxWorkingHrs)
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
                empWage = empHr * empRatePerHr;
                totalWage = totalWage + empWage;
                //Console.WriteLine("Day{0} Employee WAGE Is:{1}", day, empWage);
                day++;
                totalWorkingHrs = totalWorkingHrs + empHr;
                if (totalWorkingHrs > maxWorkingHrs)
                    totalWorkingHrs = totalWorkingHrs - empHr;
            }
            Console.WriteLine("Total Wage for {0}: {1} days and Hrs:{2} is:{3}", companyName, (day - 1), (totalWorkingHrs), totalWage);
        }
    }
}
