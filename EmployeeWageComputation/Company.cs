using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Company
    {
        public string CompanyName;
        public int numberOfWorkingDays, maxWorkingHrs, empRatePerHr, totalWage;

        public Company(string compny,int workingDays,int workingHrs,int ratePerHr)
        {

            CompanyName = compny;
            numberOfWorkingDays = workingDays;
            maxWorkingHrs = workingHrs;
            empRatePerHr = ratePerHr;
        }
        public void SetTotalWage(int total)
        {
            totalWage = total; 
        }
        public override string ToString()
        {
            return $"\nCompany:{CompanyName} NumbOfWorkingDays:{numberOfWorkingDays} WorkingHrs:{maxWorkingHrs} ratePerHr:{empRatePerHr},totalWage:{totalWage}";
        }
    }
}
