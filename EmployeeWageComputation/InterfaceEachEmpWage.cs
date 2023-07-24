using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal interface InterfaceEachEmpWage
    {
        void AddCompanyObjectsIntoArray(string compny, int workingDays, int workingHrs, int ratePerHr);
        int CalculateEmpWage(Company company);
    }
}
