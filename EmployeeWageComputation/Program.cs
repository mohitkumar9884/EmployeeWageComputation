namespace EmployeeWageComputation
 {
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome To EmployeeWageComputation");
            EachEmpWage spacex = new EachEmpWage("SpaceX", 27, 86, 29);
            spacex.CalculateEmpWage();
            EachEmpWage reliance = new EachEmpWage("Reliance", 25, 84, 31);
            reliance. CalculateEmpWage();
            EachEmpWage latentview = new EachEmpWage("Latentview", 28, 90, 35);
            latentview. CalculateEmpWage();
        }
        
    }
    
    
}