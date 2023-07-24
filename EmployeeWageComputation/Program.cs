namespace EmployeeWageComputation
 {
    internal class Program
    {
         static void Main(string[] args)
         {
            Console.WriteLine("Welcome To EmployeeWageComputation");
            EachEmpWage empWageCompute = new EachEmpWage();
            empWageCompute.AddCompanyObjectsIntoArray("SpaceX", 27, 86, 29);
            empWageCompute.AddCompanyObjectsIntoArray("Reliance", 25, 84, 31);
            empWageCompute.AddCompanyObjectsIntoArray("Latentview", 28, 90, 35);
            empWageCompute.IterateOverArray();
            int total = empWageCompute.GetTotalWageBasedOnCompany("Reliance");
            /*if (total != 0)
                Console.WriteLine("TotalWage is:"+total);
            else
                Console.WriteLine("Given company not exist");*/
               
         }
        
    }
    
    
}