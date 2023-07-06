namespace EmployeeWageComputation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int FULL_TIME = 0;
            const int PART_TIME = 2;
            const int RATE_PER_HOUR = 20;
            int empHr = 0;
            int empWage = 0;

            Console.WriteLine("Welcome To EmployeeWageComputation");
            Random random = new Random();
            int employeeInput = random.Next(0, 3);// 0 or 1 or 2

            Console.WriteLine("Random value:{0}", employeeInput);

            if (employeeInput == FULL_TIME)
            {
                Console.WriteLine("FullTime Employee Is Present");
                empHr = 8;
            }
            else if (employeeInput== PART_TIME)
            {
                Console.WriteLine("PartTime Employee Is Present");
                empHr = 4;
            }
            else
            {
                Console.WriteLine("Employee Is Not Present");
            }
            empWage = empHr * RATE_PER_HOUR;
            Console.WriteLine("Dialy Employee WAGE Is:{0}", empWage);
        }
    }
    
}